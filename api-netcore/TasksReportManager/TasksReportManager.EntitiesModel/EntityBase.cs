using System.ComponentModel.DataAnnotations;

namespace TasksReportManager.EntitiesModel
{
  public abstract class EntityBase
  {
    [Key]
    public int Id { get; set; } = 0;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; } = null!;
  }
}
