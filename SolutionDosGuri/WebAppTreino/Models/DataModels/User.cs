namespace WebAppTreino.Models.DataModels;

public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;   
    public string? Phone { get; set; }
    public string? Avatar { get; set; }
    public string Password { get; set; } = String.Empty;
    public DateTime Created { get; set; } = DateTime.Now;
    public DateTime Updated { get; set; }  
}
