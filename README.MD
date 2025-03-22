# Microsoft.Extensions.AI Ollama Integration Example

This repository provides a simple example demonstrating how to integrate the `Microsoft.Extensions.AI` library with Ollama 
to interact with large language models (LLMs) in a .NET application.

## About the Library
**Microsoft.Extensions.AI** is a .NET library that simplifies AI integration into applications, 
offering components for working with various AI providers. 
The Ollama integration enables interaction with models served through the [Ollama framework](https://ollama.com/), a tool for running LLMs locally.

## Features
- Connect to a local Ollama model server
- Send prompts to the model and receive responses
- Simple console interface for interaction

## Pre-requisites
- [dotnet 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or higher
- [Ollama](https://ollama.com/)
- Phi4 model (or any other supported model) installed via Ollama

## Getting Started
1. Clone the repository
   ```bash
   git clone https://github.com/vladimir-shirmanov/PromptingWithMsExtensions
   cd PromptingWithMsExtensions
   ```
2. Run the following command to install the required packages:
   ```bash
   dotnet restore
   ```
3. Run the following command to serve the required Ollama models locally:
   ```bash
    ollama run phi4
    ```
4. Run the following command to run the project:
    ```bash
       dotnet run
    ```
   
## Integration Guide
To use Ollama in your .NET application:
1. Add the NuGet Package:
   ```bash
   dotnet add package Microsoft.Extensions.AI
   ```
2. Configure Ollama Client:
   ```csharp
   // Initialize the chat client
   IChatClient client = new OllamaChatClient(
    new Uri("http://localhost:11434"),
    "phi4");
   ```
3. Implement Chat Interaction:
```csharp
string? prompt;
do
{
    Console.WriteLine("Enter your prompt (or 'exit' to quit):");
    prompt = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(prompt) && prompt != "exit")
    {
        var response = await client.GetResponseAsync(prompt);
        Console.WriteLine(response);
    }
} while (prompt != "exit");
```

## Usage
1. Start the application 
2. Enter your prompt when requested 
3. Type 'exit' to quit 
4. Example prompts:
   - "Explain quantum computing in simple terms"
   - "Write a poem about .NET development"
   - "Help me debug this C# code"