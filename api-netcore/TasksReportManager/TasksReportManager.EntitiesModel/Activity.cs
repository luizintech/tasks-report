namespace TasksReportManager.EntitiesModel
{
  public class Activity
    : EntityBase
  {
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null!;

  }
}
