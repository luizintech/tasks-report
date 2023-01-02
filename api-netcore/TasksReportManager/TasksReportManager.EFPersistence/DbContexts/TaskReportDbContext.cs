using Microsoft.EntityFrameworkCore;
using TasksReportManager.EFPersistence.ConfigurationMappings;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration<TaskType>(new TaskTypeConfiguration());
    }

  }
}
