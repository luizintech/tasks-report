namespace TasksReportManager.EntitiesModel.UnitTests
{
  public class UserInfoUnitTest
  {

    [InlineData("Maria", false)]
    [InlineData("João", false)]
    [InlineData("Pedro", false)]
    [InlineData("Giulia", false)]
    [InlineData("", true)]
    [Theory()]
    public void Validate_EntityModel_Name(string userName, bool isEmpty)
    {
      //Arrange
      var userInfo = new UserInfo();

      //Act
      userInfo.Name = userName; 

      //Assert
      Assert.Equal(userName, userInfo.Name);
      Assert.Equal(isEmpty, string.IsNullOrEmpty(userInfo.Name));
    }

  }
}
