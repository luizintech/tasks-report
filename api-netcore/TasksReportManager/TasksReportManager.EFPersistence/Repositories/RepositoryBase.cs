using Microsoft.EntityFrameworkCore;
using TasksReportManager.EFPersistence.DbContexts;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.Repositories
{
  public abstract class RepositoryBase<TEntity>
    : IRepository<TEntity>
    where TEntity : EntityBase
  {
    private readonly TaskReportDbContext _dbContext;
    protected RepositoryBase()
      : base() { }
    public RepositoryBase(TaskReportDbContext context)
    {
      this._dbContext = context;
    }
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
      return await this._dbContext.Set<TEntity>().ToArrayAsync();
    }
    public virtual async Task<TEntity> GetByIdAsync(int id)
    {
      return await this._dbContext.Set<TEntity>().FindAsync(id);
    }
    public virtual async Task AddAsync(TEntity entity)
    {
      await this._dbContext.AddAsync(entity);
      await this._dbContext.SaveChangesAsync();
    }
    public virtual async Task UpdateAsync(TEntity entity)
    {
      this._dbContext.Update(entity);
      await this._dbContext.SaveChangesAsync();
    }

  }
}
