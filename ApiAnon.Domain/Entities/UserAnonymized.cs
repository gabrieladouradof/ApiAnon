using Microsoft.EntityFrameworkCore;

namespace ApiAnon.Domain.Entities 
{
[Keyless]
public class UserAnonymized
{
    public string? NameAnonymized { get; set; }
    public string? CPFAnonymized { get; set; }
    public string? Gender { get; set; }
    //public string? HashKey { get; set; }

}
}