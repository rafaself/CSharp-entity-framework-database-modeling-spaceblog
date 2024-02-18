using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
            .HasOne<Post>(comment => comment.Post)
            .WithMany(post => post.Comments)
            .HasForeignKey(comment => comment.PostId)
            .OnDelete(DeleteBehavior.NoAction);


        builder
            .HasOne<User>(comment => comment.User)
            .WithMany(user => user.Comments)
            .HasForeignKey(comment => comment.UserId)
            .OnDelete(DeleteBehavior.NoAction);

    }

   
}
