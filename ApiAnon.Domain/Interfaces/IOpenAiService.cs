
namespace ApiAnon.Domain.Interfaces
{
    // Interface for the OpenAI service that will be used to generate fake names and CPFs.
    public interface IOpenAiService
    {
        Task<string> GenerateFakeName (string originalName, string gender);
    }
}