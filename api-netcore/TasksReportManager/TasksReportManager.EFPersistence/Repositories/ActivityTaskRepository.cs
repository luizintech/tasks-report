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
  }
}
