using ApiAnon.Domain.Interfaces;
using ApiAnon.Domain.Entities;
using System.Security.Cryptography;
using System.Text;

namespace ApiAnon.Infra.Services
{
    //service implementation and data anonymization interface
    public class AnonymizationService : IAnonymizationService
    {
        private readonly IOpenAiService _openAiService;

        //Constructor that receives an instance of IOpenAiService via dependency injection.
        public AnonymizationService(IOpenAiService openAiService)
        {
            _openAiService = openAiService;
        }
        
        //Method that anonymizes the name and CPF using hash and OpenAI.
        public async Task<(string anonymizedName, string anonymizedCpf)> AnonymizeData (string name, string cpf, string gender)
        {
            // Generates a hash based on name and CPF.
            string hashKey = GenerateHash(name + cpf);

            // Generate a fake name using OpenAI.
            string fakeName = await _openAiService.GenerateFakeName(name, gender);

            // Generates a false CPF.
            string fakeCpf = GenerateFakeCpf();

            // Returns the anonymized name and CPF.
            return (fakeName, fakeCpf);
        }

        // Method that generates a SHA256 hash for a given string.
        private string GenerateHash(string input)
        {
            // Creates a SHA256 instance to compute the hash.
            using (SHA256 sha256 = SHA256.Create())
            {
                 //Converts the imput string to a byte array
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                  //Initizalizes a StringBuilder to create the hexadecimal string
                StringBuilder builder = new StringBuilder();
                 // Iterates over each byte of the array and converts it to a hexadecimal string.
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                 //Returns the hexadecimal string, which is the hash representation.
                return builder.ToString();
            }
        }

        // Method that generates a random false CPF.
        private string GenerateFakeCpf()
        {
            Random random = new Random();
            StringBuilder cpfBuilder = new StringBuilder();
            for (int i = 0; i < 11; i++)
            {
                cpfBuilder.Append(random.Next(0, 10));
            }
            return cpfBuilder.ToString();
        }
    }
}

//This service is responsible for anonymizing user data.
// It combines the original name and CPF to generate a hash key, 
//uses OpenAI to generate a fake name, and creates a fake CPF.
       