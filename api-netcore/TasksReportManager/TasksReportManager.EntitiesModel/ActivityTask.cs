namespace TasksReportManager.EntitiesModel
{
  public class ActivityTask
    : EntityBase
  {

    public int TaskTypeId { get; set; } = 0;
    public TaskType TaskType { get; set; } = new TaskType();
    public int ActivityId { get; set; } = 0;
    public Activity Activity { get; set; } = new Activity();
    public string Url { get; set; } = string.Empty;
    public TimeSpan TimeElapsed { get; set; } = TimeSpan.FromSeconds(0);

  }
}
