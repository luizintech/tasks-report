using TasksReportManager.EntitiesModel;

namespace TasksReportManager.Application.Dtos.ActivityTasks
{
  public static class ActivityTaskDtoExtension
  {
    public static ActivityTask ToEntityModel(this ActivityTaskEditDto source)
    {
      return new ActivityTask()
      {
        ActivityId = source.ActivityId,
        TaskTypeId = source.TaskTypeId,
        TimeElapsed = source.TimeElapsed.ToTimeSpan(),
        Url = source.Url
      };
    }

    public static ActivityTask FillModel(this ActivityTaskEditDto source, ActivityTask activityTask)
    {
      if (source.ActivityId != activityTask.ActivityId)
        activityTask.ActivityId = source.ActivityId;

      if (source.TaskTypeId != activityTask.TaskTypeId)
        activityTask.TaskTypeId = source.TaskTypeId;

      if (source.TimeElapsed.ToTimeSpan() != activityTask.TimeElapsed)
        activityTask.TimeElapsed = source.TimeElapsed.ToTimeSpan();

      if (source.Url != activityTask.Url)
        activityTask.Url = source.Url;

      return activityTask;
    }

  }
}
