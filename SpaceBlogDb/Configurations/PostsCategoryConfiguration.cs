using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Configurations;

public class PostsCategoryConfiguration : IEntityTypeConfiguration<PostsCategory>
{
    public void Configure(EntityTypeBuilder<PostsCategory> builder)
    {
        builder
            .HasMany<PostsCategoryPost>(postsCategory => postsCategory.PostsCategoriesPosts)
            .WithOne();

    }
}
