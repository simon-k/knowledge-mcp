using KnowledgeMcp.Server;
using KnowledgeMcp.Server.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var options = new KnowledgeBaseOptions
{
    OpenAiApiKey = args[0],
    Neo4JUri = args[1],
    Neo4JUsername = args[2],
    Neo4JPassword = args[3]
};

var builder = Host.CreateApplicationBuilder();
builder.Logging.AddConsole(consoleLogOptions =>
{
    consoleLogOptions.LogToStandardErrorThreshold = LogLevel.Trace;
});

builder.Services
    .AddMcpServer()
    .WithStdioServerTransport()
    .WithToolsFromAssembly();

builder.Services.AddSingleton(options);
builder.Services.AddSingleton<KnowledgeService>();

await builder.Build().RunAsync();
