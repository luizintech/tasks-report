using TasksReportManager.EFPersistence.DbContexts;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.Repositories
{
  public class TaskTypeRepository
    : RepositoryBase<TaskType>
  {
    public TaskTypeRepository(TaskReportDbContext context)
      : base(context)
    {
    }
  }
}
