using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using TasksReportManager.EFPersistence.DbContexts;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.Repositories
{
  public class ActivityTaskRepository
    : RepositoryBase<ActivityTask>
  {
    public ActivityTaskRepository(TaskReportDbContext context)
      : base(context)
    {
    }

    public override async Task<IEnumerable<ActivityTask>> GetAllAsync()
    {
      return await _dbContext.Set<ActivityTask>()
        .Include(c => c.Activity)
        .Include(c => c.TaskType)
        .ToArrayAsync();
    }
  }
}
