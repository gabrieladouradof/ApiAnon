namespace ApiAnon.Domain.Entities 
{
public class User 
{
    public int Id { get; set; }
    public string? Cpf { get; set; }
    public string? Gender { get; set; }
    public string? NameAnonymized { get; set; }
    public string? CPFAnonymized { get; set; }
    public string? HashKey { get; set; }

}
}