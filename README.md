# knowledge-mcp
MCP Server that serves knowledge from a Neo4J Database.

__The documents provided in this example are dummy guidelines. They are not real and serve the purpose to demonstrate
that knowledge can be extracted from Neo4J.__

This is a prototype and is not ready for production use!

# Getting Started
## Run Neo4J in a Docker Container
Run Neo4J Docker Container
```bash
docker run \
    --restart always \
    --publish=7474:7474 \
    --publish=7687:7687 \
    neo4j:latest
```

Login to Neo4J in the browser http://localhost:7474/ and set a new password for the user `neo4j`.

## Run the Data Loader
Run the Data Load er project to save some documents in Neo4J.These documents will be used by the MCP server to answer 
questions.

_Remember to change the source code so that it points to the Neo4J instance you are running and the Neo4J username 
and password is set according to the one you set in the previous step._

## Build the MCP Server
Build the server to generate the binaries that are needed.

## Configure the MCP Server in Cursor
Go to Cursor Settings and add a new MCP server.

Remember to set the `YOUR_PATH`, `YOUR_OPENAI_API_KEY`and `YOUR_NEO4J_PASSWORD` to the correct values.

```json
{
  "mcpServers": {
    "KnowledgeBase": {
      "type": "stdio",
      "command": "YOUR_PATH/knowledge-mcp/src/KnowledgeMcp.Server/bin/Debug/net9.0/KnowledgeMcp.Server",
      "args": [
        "YOUR_OPEN_AI_API_KEY",
        "neo4j://localhost:7687",
        "neo4j",
        "YOUR_NEO4J_PASSWORD"
      ]
    }
  }
}
```

# Notes
* You can use the MCP server in any client that supports MCP. Fx the Claude Desktop.
* A possible first improvement could be to use Neo4Js response format to get a citation to the document used to answer the question.

