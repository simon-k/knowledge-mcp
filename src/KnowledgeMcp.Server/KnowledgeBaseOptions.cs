namespace KnowledgeMcp.Server;

public class KnowledgeBaseOptions
{
    public required string OpenAiApiKey { get; set; }
    public required string Neo4JUri { get; set; }
    public required string Neo4JUsername { get; set; }
    public required string Neo4JPassword { get; set; }
}
