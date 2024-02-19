using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class UserRepository(CustomDbContext dbContext) : BaseRepository<User>(dbContext)
{

    public async Task UpdateUserName(int id, string name)
    {
        var user = await _dbContext.Set<User>()
            .Where(entity => entity.Id == id)
            .FirstAsync();

        user.Name = name;
    }

}
