using System.ComponentModel;
using KnowledgeMcp.Server.Services;
using ModelContextProtocol.Server;

namespace KnowledgeMcp.Server.Tools;

[McpServerToolType]
public static class KnowledgeTool
{
    [McpServerTool, Description("Answers questions about Azure Services")]
    public static async Task<string> AzureKnowledgeBaseK(KnowledgeService knowledgeService, string question)
    {
        var answer = await knowledgeService.GetAnswerAsync(question);
        return answer;
    }
}
