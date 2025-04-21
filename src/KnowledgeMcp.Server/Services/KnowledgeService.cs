using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.KernelMemory;
using Neo4j.KernelMemory.MemoryStorage;

namespace KnowledgeMcp.Server.Services;

public class KnowledgeService
{
    private readonly MemoryServerless _kernelMemory;

    public KnowledgeService(KnowledgeBaseOptions options)
    {
        //TODO: Yea I know. All of the Neo4J stuff should be injected and not hardcoded here...
        var kernelMemoryBuilder = new KernelMemoryBuilder()
            .WithOpenAIDefaults(options.OpenAiApiKey)
            .WithNeo4j(new Neo4jConfig
            {
                Uri = options.Neo4JUri,
                Username = options.Neo4JUsername,
                Password = options.Neo4JPassword,
            });

        kernelMemoryBuilder.Services.AddLogging(c =>
        {
            c.AddConsole().SetMinimumLevel(LogLevel.Critical);
        });
        
        _kernelMemory = kernelMemoryBuilder.Build<MemoryServerless>();
    }
    
    public async Task<string> GetAnswerAsync(string question)
    {
        var answer = await _kernelMemory.AskAsync(question);
        //TODO: amswer can also give you a citation and other cool stuff.
        return answer.Result;
    }
}
