using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureAIInference;

#pragma warning disable SKEXP0070

const string ModelId = "<DEPLOYMENT-NAME>";
const string Endpoint = "<ENDPOINT>";
const string ApiKey = "<API-KEY>";

const string SystemMessage =
    """
    Assistant is a conversational agent named DeepSeek. It's purpose is to discuss any topic with the user.
    Initially greet the user, introduce yourself, and mention that conversation can be stopped by typing "exit" in the chat. Then continue with the conversation.
    Limit answers to 50-100 words. If the user asks for more information, provide a brief answer and ask if they would like more details.
    """;

var builder = Kernel.CreateBuilder().AddAzureAIInferenceChatCompletion(ModelId, ApiKey, new Uri(Endpoint));
builder.Services.AddLogging(loggingBuilder => loggingBuilder.SetMinimumLevel(LogLevel.Information).AddConsole());
var kernel = builder.Build();
var executionSettings = new AzureAIInferencePromptExecutionSettings { MaxTokens = 2048 };
var chatCompletion = kernel.GetRequiredService<IChatCompletionService>();

ChatHistory history = [];
history.AddSystemMessage(SystemMessage);
var result = await chatCompletion.GetChatMessageContentAsync(history, executionSettings);
string? output = result.Content;
if (!string.IsNullOrEmpty(output))
{
    WriteAgentMessage(output);
    history.AddAssistantMessage(output);
}
do
{
    string? input = ReadUserMessage();
    if (input is null || input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;
    history.AddUserMessage(input);
    result = await chatCompletion.GetChatMessageContentAsync(history, executionSettings);
    output = result.Content;
    if (string.IsNullOrEmpty(output))
    {
        WriteAgentMessage("Exiting...");
        break;
    }
    WriteAgentMessage(output);
    history.AddAssistantMessage(output);
} while (true);
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
