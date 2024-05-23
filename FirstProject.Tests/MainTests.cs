namespace FirstProject.Tests;

public class MainTests
{
    private IMockConsoleUI _cui = new MockConsoleUI();

    [Fact]
    public void ReceiveEmployeeWage_Converts_String_To_Integer()
    {
        //Arrange
        _cui.SetInput = "20000";
        Main main = new Main(_cui);

        //Act & Assert
        Assert.Equal(20000, main.ReceiveEmployeeWage());
    }

    [Fact]
    public void ReceiveEmployeeName_Returns_Passed_In_Name()
    {
        //Arrange
        _cui.SetInput = "Test Test";
        Main main = new Main(_cui);

        //Act & Assert
        Assert.Equal("Test Test", main.ReceiveEmployeeName());
    }
}
