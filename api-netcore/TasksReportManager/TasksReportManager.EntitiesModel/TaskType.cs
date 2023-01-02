namespace TasksReportManager.EntitiesModel
{
    public class TaskType
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; } = null!;

    }
}
