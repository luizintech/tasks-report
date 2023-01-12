using System.ComponentModel.DataAnnotations;

namespace TasksReportManager.Application.Dtos.Activities
{
  public class ActivityEditDto
  {
    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
    [Required]
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null!;
  }
}
