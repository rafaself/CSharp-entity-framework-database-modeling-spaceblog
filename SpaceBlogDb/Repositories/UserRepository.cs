using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class UserRepository(CustomDbContext dbContext) : BaseRepository<User>(dbContext)
{
}
