using Microsoft.EntityFrameworkCore;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.DbContexts
{
  public class TaskReportDbContext
    : DbContext
  {
    public TaskReportDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TaskType> TaskTypes { get; set; }

  }
}
