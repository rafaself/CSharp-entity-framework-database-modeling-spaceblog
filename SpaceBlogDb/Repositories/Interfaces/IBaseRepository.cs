using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Repositories.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class, IBaseModel
{
    void Create(TEntity entity);
    Task<TEntity> GetByIdAsync(int id);
}
