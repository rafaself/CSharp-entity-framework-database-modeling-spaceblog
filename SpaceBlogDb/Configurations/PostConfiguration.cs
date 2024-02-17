using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder
            .HasOne<User>(post => post.User)
            .WithMany(user => user.Posts)
            .HasForeignKey(post => post.UserId);

        builder
            .HasMany<Comment>(post => post.Comments)
            .WithOne(comment => comment.Post);

        builder
            .HasMany<PostsCategoryPost>(post => post.PostsCategoriesPosts)
            .WithOne(postCategoryPost => postCategoryPost.Post);
    }
}
