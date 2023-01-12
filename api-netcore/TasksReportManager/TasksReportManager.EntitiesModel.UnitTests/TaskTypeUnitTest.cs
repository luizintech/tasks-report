namespace TasksReportManager.EntitiesModel.UnitTests
{
  public class TaskTypeUnitTest
  {

    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(0, 0)]
    [Theory()]
    public void Validate_EntityModel_Id(int idField, int expected)
    {
      //Arrange
      var taskType = new TaskType();

      //Act
      taskType.Id = idField;

      //Assert
      Assert.Equal(idField, taskType.Id);
      Assert.Equal(taskType.Id, expected);
      Assert.NotEqual(int.MinValue, taskType.Id);
    }

    [InlineData("Video", false)]
    [InlineData("Exercicio", false)]
    [InlineData("", true)]
    [Theory()]
    public void Validate_EntityModel_Name(string typeName, bool isEmpty)
    {
      //Arrange
      var taskType = new TaskType();

      //Act
      taskType.Name = typeName; 

      //Assert
      Assert.Equal(typeName, taskType.Name);
      Assert.Equal(isEmpty, string.IsNullOrEmpty(taskType.Name));
    }

    [InlineData("2023-01-02", "2023-01-02")]
    [InlineData("2022-12-30", "2022-12-30")]
    [Theory()]
    public void Validate_EntityModel_CreatedAt(string enterDateString, string expectedDateString)
    {
      //Arrange
      var taskType = new TaskType();
      var enterDate = DateTime.Parse(enterDateString);
      var expectedDate = DateTime.Parse(expectedDateString);

      //Act
      taskType.CreatedAt = enterDate;

      //Assert
      Assert.Equal(expectedDate, taskType.CreatedAt);
      Assert.NotEqual(DateTime.MinValue, taskType.CreatedAt);
    }

    [Fact()]
    public void Validate_EntityModel_DeletedAt()
    {
      //Arrange
      var taskType = new TaskType();
      DateTime? enterDate = null;

      //Act
      taskType.DeletedAt = enterDate;

      //Assert
      Assert.Equal(enterDate, taskType.DeletedAt);
    }

  }
}
