namespace ApiAnon.Domain.Entities 
{

// User Entity that represents user data in the database.
public class User 
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CPF { get; set; }
    public string? Gender { get; set; }

}

// AnonymizedUser entity that represents the anonymized user data in the database.
public class AnonymizedUser
{
    public int Id { get; set; }
    public string? AnonymizedName { get; set; }
    public string? AnonymizedCPF { get; set; }
    public string? HashKey { get; set; }

}
}