using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class PostCategoryRepository : BaseRepository<PostsCategory>
{

    public PostCategoryRepository(CustomDbContext dbContext) : base(dbContext) { }

}
