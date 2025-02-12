<!-- Improved compatibility of back to top link -->
<a id="readme-top"></a>

<!-- PROJECT SHIELDS -->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/uveta/demo-azure-deepseek">
    <img src="images/deepseek-color.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Deploy and use DeepSeek R1 with Azure and .NET</h3>

  <p align="center">
    Showcasing DeepSeek R1 deployment to Azure and integration with .NET and Semantic Kernel
    <br />
    <a href="https://github.com/uveta/demo-azure-deepseek"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/uveta/demo-azure-deepseek/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    &middot;
    <a href="https://github.com/uveta/demo-azure-deepseek/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

Showcasing DeepSeek R1 deployment to Azure and integration with .NET and Semantic Kernel. This is a companion repository for blog post [Deploy and use DeepSeek R1 with Azure and .NET](https://www.uveta.io/categories/blog/deploy-and-use-deepseek-r1-with-azure-and-net/).

<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Built With

* [![Dotnet][Dotnet.com]][Dotnet-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

You need to have .NET 9.0 SDK installed.

### Configuration

1. Follow the steps in the blog post [Deploy and use DeepSeek R1 with Azure and .NET](https://www.uveta.io/categories/blog/deploy-and-use-deepseek-r1-with-azure-and-net/) to deploy DeepSeek R1 model to Azure cloud.
2. Get endpoint URL, API key, and deployment name from deployment details, as shown in the blog post.
3. Replace `<DEPLOYMENT-NAME>`, `<ENDPOINT-URL>`, and `<API-KEY>` in source code with your deployment info.
  ```csharp
  const string ModelId = "<DEPLOYMENT-NAME>";
  const string Endpoint = "<ENDPOINT>";
  const string ApiKey = "<API-KEY>";
  ```
4. Run any project using dotnet CLI or IDE of your choice.
  ```pwsh
  dotnet run --project src/DeepSeek.NET
  dotnet run --project src/DeepSeek.SemanticKernel
  ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- USAGE EXAMPLES -->
## Usage

Run either `DeepSeek.NET` or `DeepSeek.SemanticKernel` project using dotnet CLI or IDE of your choice. If everything is configured correctly, you should see the output similar to the following:

<!-- image/usage.png -->
![DeepSeek R1 console chat][product-screenshot]

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- LICENSE -->
## License

Distributed under the MIT license. See [`LICENSE`](./LICENSE) for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- CONTACT -->
## Contact

Uroš Miletić - [@uveta](https://www.github.com/uveta)

Project Link: [https://github.com/uveta/demo-azure-deepseek](https://github.com/uveta/demo-azure-deepseek)

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/uveta/demo-azure-deepseek.svg?style=for-the-badge
[contributors-url]: https://github.com/uveta/demo-azure-deepseek/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/uveta/demo-azure-deepseek.svg?style=for-the-badge
[forks-url]: https://github.com/uveta/demo-azure-deepseek/network/members
[stars-shield]: https://img.shields.io/github/stars/uveta/demo-azure-deepseek.svg?style=for-the-badge
[stars-url]: https://github.com/uveta/demo-azure-deepseek/stargazers
[issues-shield]: https://img.shields.io/github/issues/uveta/demo-azure-deepseek.svg?style=for-the-badge
[issues-url]: https://github.com/uveta/demo-azure-deepseek/issues
[license-shield]: https://img.shields.io/github/license/uveta/demo-azure-deepseek.svg?style=for-the-badge
[license-url]: https://github.com/uveta/demo-azure-deepseek/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/uveta
[product-screenshot]: images/usage.png
[Dotnet.com]: https://img.shields.io/badge/-.NET%209.0-blueviolet
[Dotnet-url]: https://dotnet.microsoft.com
