using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models.Interfaces;
using SpaceBlogDb.Repositories.Interfaces;

namespace SpaceBlogDb.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseModel
{

    protected readonly CustomDbContext _dbContext;

    public BaseRepository(CustomDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Create(TEntity entity)
    {
        if (entity == null) throw new InvalidOperationException("Entity can't be null");

        _dbContext.Add(entity);

    }

    public Task<TEntity> GetByIdAsync(int id)
    {
        return _dbContext.Set<TEntity>()
            .AsNoTracking()
            .Where(entity => entity.Id == id)
            .FirstAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await _dbContext.Set<TEntity>()
            .Where(entity => entity.Id == id)
            .FirstAsync();

        _dbContext.Remove(entity);
    }

}
