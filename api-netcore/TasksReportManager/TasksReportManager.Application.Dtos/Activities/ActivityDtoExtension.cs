using TasksReportManager.EntitiesModel;

namespace TasksReportManager.Application.Dtos.Activities
{
  public static class ActivityDtoExtension
  {
    public static Activity ToEntityModel(this ActivityEditDto source)
    {
      return new Activity()
      {
        Name = source.Name,
        StartDate = source.StartDate,
        EndDate = source.EndDate
      };
    }

    public static Activity FillModel(this ActivityEditDto source, Activity activity)
    {
      if (source.Name != activity.Name)
        activity.Name = source.Name;

      if (source.StartDate != activity.StartDate)
        activity.StartDate = source.StartDate;

      if (source.EndDate != activity.EndDate)
        activity.EndDate = source.EndDate;

      return activity;
    }

  }
}
