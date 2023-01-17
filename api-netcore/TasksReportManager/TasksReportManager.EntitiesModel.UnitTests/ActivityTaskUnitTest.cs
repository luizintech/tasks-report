namespace TasksReportManager.EntitiesModel.UnitTests
{
  public class ActivityTaskUnitTest
  {

    [Fact()]
    public void Validate_EntityModel_ElapsedTime()
    {
      //Arrange
      var task = new ActivityTask();
      var typeElapsed = TimeSpan.FromSeconds(120);
      var zeroValue = 0; 

      //Act
      task.TimeElapsed = typeElapsed; 

      //Assert
      Assert.NotEqual(task.TimeElapsed.Minutes, zeroValue);
    }

    [Fact()]
    public void Validate_EntityModel_ActivityId()
    {
      //Arrange
      var task = new ActivityTask();
      var activityId = 1;
      var zeroValue = 0;

      //Act
      task.ActivityId = activityId;

      //Assert
      Assert.NotEqual(task.ActivityId, zeroValue);
    }

    [Fact()]
    public void Validate_EntityModel_TaskTypeId()
    {
      //Arrange
      var task = new ActivityTask();
      var taskTypeId = 1;
      var zeroValue = 0;

      //Act
      task.TaskTypeId = taskTypeId;

      //Assert
      Assert.NotEqual(task.TaskTypeId, zeroValue);
    }

    [InlineData("https://www.google.com/", true)]
    [InlineData("https://www.uol.com.br/", true)]
    [InlineData("locahost", false)]
    [Theory()]
    public void Validate_EntityModel_Url(string entryUrl, bool validUrl)
    {
      //Arrange
      var task = new ActivityTask();

      //Act
      task.Url = entryUrl;

      //Assert
      Assert.NotNull(entryUrl);
      Assert.Equal(entryUrl.StartsWith("http"), validUrl);
    }

  }
}
