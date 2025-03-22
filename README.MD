# How to run this project

## Pre-requisites
- [dotnet 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or higher
- [Ollama](https://ollama.com/)

## Steps to run
1. Clone the repository
2. Navigate to the project directory
3. Run the following command to install the required packages:
   ```bash
   dotnet restore
   ```
4. Run the following command to serve the required Ollama models locally:
   ```bash
    ollama run phi4
    ```
5. Run the following command to build the project:
   ```bash
    dotnet build
    ```
6. Run the following command to run the project:
    ```bash
       dotnet run
    ```