using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.ConfigurationMappings
{
  public class TaskTypeConfiguration
    : IEntityTypeConfiguration<TaskType>
  {
    public void Configure(EntityTypeBuilder<TaskType> builder)
    {
      builder.ToTable<TaskType>("TaskTypes");

      builder.HasKey(x => x.Id);

      builder.Property(m => m.Id)
          .HasColumnName("id");

      builder.Property(m => m.Name)
          .HasColumnName("name")
          .HasColumnType("varchar(30)")
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
