namespace TasksReportManager.Application.Dtos.Messages
{
    public class ResultDto
    {
      public int Id { get; set; } = 0;
      public IList<string> Messages { get; set; } = new List<string>();
      public bool Success { get; set; } = false;
    }
}
