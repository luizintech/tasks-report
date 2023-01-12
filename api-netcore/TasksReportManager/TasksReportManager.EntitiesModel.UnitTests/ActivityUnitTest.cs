namespace TasksReportManager.EntitiesModel.UnitTests
{
  public class ActivityUnitTest
  {

    [InlineData("Curso de AWS", false)]
    [InlineData("Curso de Inglês", false)]
    [InlineData("", true)]
    [Theory()]
    public void Validate_EntityModel_Name(string typeName, bool isEmpty)
    {
      //Arrange
      var activity = new Activity();

      //Act
      activity.Name = typeName; 

      //Assert
      Assert.Equal(typeName, activity.Name);
      Assert.Equal(isEmpty, string.IsNullOrEmpty(activity.Name));
    }

    [InlineData("2023-01-02", "2023-01-02")]
    [InlineData("2022-12-30", "2022-12-30")]
    [Theory()]
    public void Validate_EntityModel_StartDate(string enterDateString, string expectedDateString)
    {
      //Arrange
      var activity = new Activity();
      var enterDate = DateTime.Parse(enterDateString);
      var expectedDate = DateTime.Parse(expectedDateString);

      //Act
      activity.StartDate = enterDate;

      //Assert
      Assert.Equal(expectedDate, activity.StartDate);
      Assert.NotEqual(DateTime.MinValue, activity.StartDate);
    }

    [Fact()]
    public void Validate_EntityModel_EndDate()
    {
      //Arrange
      var activity = new Activity();
      DateTime? enterDate = null;

      //Act
      activity.EndDate = enterDate;

      //Assert
      Assert.Equal(enterDate, activity.EndDate);
    }

  }
}
