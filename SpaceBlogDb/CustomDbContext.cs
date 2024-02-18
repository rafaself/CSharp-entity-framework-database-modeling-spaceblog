using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SpaceBlogDb.Models;

namespace SpaceBlogDb;

public class CustomDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Post>? Posts { get; set; }
    public DbSet<PostsCategory>? PostsCategories { get; set; }
    public DbSet<Comment>? Comments { get; set; }
    public DbSet<PostsCategoryPost>? PostsCategoryPost { get; set; }

    public CustomDbContext()
    {

    }

    public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        if (options.IsConfigured) return;

        string connectionString = "Server=localhost;Database=TutorialDB;Trusted_Connection=True;TrustServerCertificate=true;";
        options.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

}
