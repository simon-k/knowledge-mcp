using Microsoft.KernelMemory;

namespace KnowledgeMcp.DataLoader;

public class DocumentLoader(MemoryServerless kernelMemory)
{
    /// <summary>
    /// Load all documents into the kernel memory.
    /// 
    /// Documents follow the convention that they are placed in the Documents folder and the file name is the same as
    /// the document name, postfixed with ".md". Fx "Documents/CosmosDB.md" for the document "CosmosDB".
    /// </summary>
    public async Task LoadAllDocumentsAsync()
    {
        await LoadDocumentAsync("CosmosDB" );
        await LoadDocumentAsync("CDN");
        await LoadDocumentAsync("KeyVault");
    }

    private async Task LoadDocumentAsync(string name)
    {
        var doc = new Document(name)
            .AddFile($"Documents/{name}.md")
            .AddTag("Company", "SKFD Inc.")
            .AddTag("Provider", "Azure")
            .AddTag("Category", "Security")
            .AddTag("Version", "1.0");
    
        await kernelMemory.ImportDocumentAsync(doc);
    }
}
