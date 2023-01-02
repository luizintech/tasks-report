namespace TasksReportManager.EntitiesModel.UnitTests
{
  public class TaskTypeUnitTest
  {

    [InlineData("Video", false)]
    [InlineData("Exercicio", false)]
    [Theory()]
    public void Validate_EntityModel(string typeName, bool isEmpty)
    {
      //Arrange
      var taskType = new TaskType();

      //Act
      taskType.Name = typeName; 

      //Assert
      Assert.Equal(typeName, taskType.Name);
      Assert.Equal(isEmpty, string.IsNullOrEmpty(taskType.Name));
    }
  }
}
