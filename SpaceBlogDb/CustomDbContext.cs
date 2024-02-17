using Microsoft.EntityFrameworkCore;

namespace SpaceBlogDb;

public class CustomDbContext : DbContext
{

    public CustomDbContext ()
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
        options.UseSqlServer(connectionString);
    }

}
