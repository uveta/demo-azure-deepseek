using Azure;
using Azure.AI.Inference;

const string Endpoint = "<ENDPOINT>";
const string ApiKey = "<API-KEY>";

const string SystemMessage =
    """
    Assistant is a conversational agent named DeepSeek. It's purpose is to discuss any topic with the user.
    Initially greet the user, introduce yourself, and mention that conversation can be stopped by typing "exit" in the chat. Then continue with the conversation.
    Limit answers to 50-100 words. If the user asks for more information, provide a brief answer and ask if they would like more details.
    """;
try
{
    var chatCompletion = new ChatCompletionsClient(new Uri(Endpoint), new AzureKeyCredential(ApiKey));
    List<ChatRequestMessage> history = [new ChatRequestSystemMessage(SystemMessage)];
    var options = new ChatCompletionsOptions { Messages = history, MaxTokens = 2048 };

    var response = await chatCompletion.CompleteAsync(options);
    string? output = response.Value.Content;
    if (!string.IsNullOrEmpty(output))
    {
        WriteAgentMessage(output);
        history.Add(new ChatRequestAssistantMessage(output));
    }
    do
    {
        string? input = ReadUserMessage();
        if (input is null || input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;
        history.Add(new ChatRequestUserMessage(input));
        response = await chatCompletion.CompleteAsync(options);
        output = response.Value.Content;
        if (string.IsNullOrEmpty(output)) break;
        WriteAgentMessage(output);
        history.Add(new ChatRequestAssistantMessage(output));
    } while (true);
}
catch (Exception e)
{
    Console.WriteLine($"Error: {e.Message}");
    Console.WriteLine(e.StackTrace);
}
WriteAgentMessage("Exiting...");
return;

string? ReadUserMessage()
{
    Console.Write("User > ");
    return Console.ReadLine();
}

void WriteAgentMessage(string message)
{
    Console.WriteLine($"DeepSeek > {message}");
}
