using TasksReportManager.EFPersistence.DbContexts;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.Repositories
{
  public class ActivityRepository
    : RepositoryBase<Activity>
  {
    public ActivityRepository()
    {
    }

    public ActivityRepository(TaskReportDbContext context)
      : base(context)
    {
    }
  }
}
