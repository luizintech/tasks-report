using System.ComponentModel.DataAnnotations;

namespace TasksReportManager.Application.Dtos.TaskTypes
{
  public class TaskTypeEditDto
  {
    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
  }
}
