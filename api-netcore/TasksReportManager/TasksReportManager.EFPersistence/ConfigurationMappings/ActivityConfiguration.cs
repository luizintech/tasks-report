using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.EFPersistence.ConfigurationMappings
{
  public class ActivityConfiguration
    : IEntityTypeConfiguration<Activity>
  {

    public void Configure(EntityTypeBuilder<Activity> builder)
    {
      builder.ToTable<Activity>("Activities");

      builder.HasKey(x => x.Id);

      builder.Property(m => m.Id)
          .HasColumnName("id");

      builder.Property(m => m.Name)
          .HasColumnName("name")
          .HasColumnType("varchar(30)")
          .IsRequired(true);

      builder.Property(m => m.StartDate)
          .HasColumnName("start_date")
          .HasColumnType("datetime2")
          .IsRequired(true);

      builder.Property(m => m.EndDate)
          .HasColumnName("end_date")
          .HasColumnType("datetime2")
          .IsRequired(false);

      builder.Property(m => m.CreatedAt)
          .HasColumnName("created_at")
          .IsRequired(true);

      builder.Property(m => m.DeletedAt)
          .HasColumnName("deleted_at")
          .IsRequired(false);

    }
  }
}
