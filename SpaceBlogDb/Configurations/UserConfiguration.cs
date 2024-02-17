using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasMany<Post>(user => user.Posts)
            .WithOne(post => post.User);

        builder
            .HasMany<Comment>(user => user.Comments)
            .WithOne(comment => comment.User);
    }
}
