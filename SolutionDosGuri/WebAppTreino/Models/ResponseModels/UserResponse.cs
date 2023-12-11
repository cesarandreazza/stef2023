namespace WebAppTreino.Models.ResponseModels;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string? Phone { get; set; }
    public string? Avatar { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Updated { get; set; }
}
