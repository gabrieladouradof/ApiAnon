using ApiAnon.Domain.Entities;
using MediatR;

// Command to anonymize a user's data.
namespace ApiAnon.Domain.Commands
{
    public class AnonymizeDataCommand : IRequest<AnonymizedUser>
    {
        public string? Name { get; set; }
        public string? CPF { get; set; }
        public string? Gender { get; set; }
        }
}
