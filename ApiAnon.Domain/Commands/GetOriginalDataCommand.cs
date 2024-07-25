using ApiAnon.Domain.Entities;
using MediatR;

// Command to obtain a user's original data from anonymized data.

namespace ApiAnon.Domain.Commands
{
    public class GetOriginalDataCommand : IRequest<User>
    {
        public string? AnonymizedName { get; set; }
        public string? AnonymizedCPF { get; set; }
    }
}