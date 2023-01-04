using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TasksReportManager.EntitiesModel;

namespace TasksReportManager.Application.Dtos.ActivityTasks
{
  public class ActivityTaskEditDto
  {
    [Required]
    public int TaskTypeId { get; set; } = 0;
    [Required]
    public int ActivityId { get; set; } = 0;
    [MaxLength(255)]
    public string Url { get; set; } = string.Empty;
    [Required]
    public string TimeElapsedEntry { get; set; }

    [JsonIgnore]
    public TimeOnly TimeElapsed
    {
      get
      {
        var timespan = new TimeSpan();
        TimeSpan.TryParse(TimeElapsedEntry, out timespan);
        var timeOnly = new TimeOnly(timespan.Ticks);
        return timeOnly;
      }
    }
  }
}
