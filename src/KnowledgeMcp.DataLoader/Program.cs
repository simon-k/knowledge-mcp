// See https://aka.ms/new-console-template for more information

using KnowledgeMcp.DataLoader;
using Microsoft.KernelMemory;
using Neo4j.KernelMemory.MemoryStorage;

// IMPORTANT. Modify the Neo4J settings to fit your environment.
var neo4jConfig = new Neo4jConfig
{
    Uri = "neo4j://localhost:7687",
    Username = "neo4j",
    Password = "YOUR_NEO4J_PASSWORD",
};

// IMPORTANT. Modify the OpenAI API Key your credentials.
var kernelMemory = new KernelMemoryBuilder()
    .WithOpenAIDefaults("YOUR_OPENAI_API_KEY")
    .WithNeo4j(neo4jConfig)
    .Build<MemoryServerless>();

var neo4J = new DocumentLoader(kernelMemory);
await neo4J.LoadAllDocumentsAsync();
