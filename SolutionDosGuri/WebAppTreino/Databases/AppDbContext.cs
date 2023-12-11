using Microsoft.EntityFrameworkCore;
using WebAppTreino.Models.DataModels;

namespace WebAppTreino.Databases;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
