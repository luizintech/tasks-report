using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.ConfigurationMappings
{
  public class ActivityTaskConfiguration
    : IEntityTypeConfiguration<ActivityTask>
  {
    public void Configure(EntityTypeBuilder<ActivityTask> builder)
    {
      builder.ToTable<ActivityTask>("Tasks");

      builder.HasKey(x => x.Id);

      builder.Property(m => m.Id)
          .HasColumnName("id");

      builder.Property(m => m.TaskTypeId)
          .HasColumnName("task_type_id")
          .IsRequired(true);

      builder.Property(m => m.ActivityId)
          .HasColumnName("activity_id")
          .IsRequired(true);

      builder.Property(m => m.Url)
          .HasColumnName("url")
          .IsRequired(false);

      builder.Property(m => m.TimeElapsed)
          .HasColumnName("time_elapsed")
          .HasColumnType("time")
          .IsRequired(true);

      builder.Property(m => m.CreatedAt)
          .HasColumnName("created_at")
          .IsRequired(true);

      builder.Property(m => m.DeletedAt)
          .HasColumnName("deleted_at")
          .IsRequired(false);

    }
  }
}
