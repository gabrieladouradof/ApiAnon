
using ApiAnon.Domain.Interfaces;
using OpenAI_API.Completions; //This library is used to assist in generating data
using OpenAI_API; //This library is used to assist in generating data

namespace ApiAnon.Infra.Services
{
    public class OpenAiService : IOpenAiService
    {
        private readonly OpenAIAPI _api;
        public OpenAiService(IConfiguration configuration)
        {
            _api = new OpenAIAPI(configuration["OpenAI:ApiKey"]);
        }

        //for generating prompts
        public async Task<string> GenerateFakeName (string originalName, string gender)
        {
            var completionRequest = new CompletionRequest
            {
                Prompt = $"Generate a fake name for a {gender} with the original name {originalName}.",
                MaxTokens = 10
            };
                 
                var completionResult = await _api.Completions.CreateCompletionAsync(completionRequest);
                return completionResult.Completions.First().Text.Trim();

        }
    }
}
