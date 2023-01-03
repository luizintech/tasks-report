using TasksReportManager.EntitiesModel;

namespace TasksReportManager.Application.Dtos.TaskTypes
{
  public static class TaskTypeDtoExtension
  {
    public static TaskType ToEntityModel(this TaskTypeEditDto source)
    {
      return new TaskType()
      {
        Name = source.Name
      };
    }

    public static TaskType FillModel(this TaskTypeEditDto source, TaskType taskType)
    {
      if (source.Name != taskType.Name)
        taskType.Name = source.Name;

      return taskType;
    }

  }
}
