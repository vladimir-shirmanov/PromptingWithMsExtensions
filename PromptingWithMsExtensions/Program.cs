using Microsoft.Extensions.AI;

IChatClient client = new OllamaChatClient(
    new Uri("http://localhost:11434"), "phi4");
string? prompt;
do
{
    Console.WriteLine("Enter your prompt (or 'exit' to quit):");
    prompt = Console.ReadLine();
    if (string.IsNullOrEmpty(prompt))
    {
        Console.WriteLine("Please enter your prompt.");
        continue;
    }

    Console.WriteLine(await client.GetResponseAsync(prompt));
} while (prompt != "exit");
