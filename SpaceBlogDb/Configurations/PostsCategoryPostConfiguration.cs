using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class PostsCategoryPostConfiguration : IEntityTypeConfiguration<PostsCategoryPost>
{
    public void Configure(EntityTypeBuilder<PostsCategoryPost> builder)
    {
        builder
            .HasOne<Post>(postsCategoryPost => postsCategoryPost.Post)
            .WithMany(post => post.PostsCategoriesPosts)
            .HasForeignKey(postsCategoryPost => postsCategoryPost.PostId);

        builder
            .HasOne<PostsCategory>(postsCategoryPost => postsCategoryPost.PostsCategory)
            .WithMany(postsCategory => postsCategory.PostsCategoriesPosts)
            .HasForeignKey(postsCategoryPost => postsCategoryPost.PostsCategoryId);
    }
}
