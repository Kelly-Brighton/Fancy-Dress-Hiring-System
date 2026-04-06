using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.Extensions.Configuration;
using System.Reflection.Metadata;

namespace FancyDressHiringSystem
{
    public class AIAgent
    {
        private Kernel kernel;

        public AIAgent()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json") // Load configuration from appsettings.json
                .Build();

            string apiKey = config["OpenAI:ApiKey"]; // Retrieve the OpenAI API key from the configuration

            var builder = Kernel.CreateBuilder(); // Create a builder for the kernel

            // Add the OpenAI chat completion service to the kernel with the specified model and API key
            builder.AddOpenAIChatCompletion(
                modelId: "gpt-4o-mini",
                apiKey: apiKey
            );

            // Build the kernel using the configured builder
            kernel = builder.Build();
        }

        public async Task<string> AskAI(string prompt) {
            var result = await kernel.InvokePromptAsync<string>(prompt); // Invoke the prompt asynchronously and get the result as a string
            return result.ToString(); // Return the result obtained from the AI
        }
    }
}
