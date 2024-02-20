using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class CommentRepository : BaseRepository<Comment>
{
    public CommentRepository(CustomDbContext dbContext) : base(dbContext)
    {

    }
}
