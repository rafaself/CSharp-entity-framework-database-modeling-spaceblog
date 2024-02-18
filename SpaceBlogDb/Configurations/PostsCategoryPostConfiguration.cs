using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class PostsCategoryPostConfiguration : IEntityTypeConfiguration<PostsCategoryPost>
{
    public void Configure(EntityTypeBuilder<PostsCategoryPost> builder)
    {
        builder.HasKey(postsCategoryPost => new { postsCategoryPost.PostsCategoryId, postsCategoryPost.PostId });

        builder
            .HasOne<Post>(postsCategoryPost => postsCategoryPost.Post)
            .WithMany(post => post.PostsCategoriesPosts)
            .HasForeignKey(postsCategoryPost => postsCategoryPost.PostId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasOne<PostsCategory>(postsCategoryPost => postsCategoryPost.PostsCategory)
            .WithMany(postsCategory => postsCategory.PostsCategoriesPosts)
            .HasForeignKey(postsCategoryPost => postsCategoryPost.PostsCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
