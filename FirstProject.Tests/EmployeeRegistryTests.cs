namespace FirstProject.Tests;

public class EmployeeRegistryTests
{
    private IMockConsoleUI _cui = new MockConsoleUI();

    [Fact]
    public void Adding_Employee_Updates_EmployeeRegistry()
    {
        //Arrange
        EmployeeRegistry employeeRegistry = new EmployeeRegistry(_cui);

        //Act
        employeeRegistry.AddEmployee("Test", 20000);
        employeeRegistry.AddEmployee("Test2", 30000);

        //Assert
        Assert.Equal(2, employeeRegistry.GetEmployeeCount());
    }
}
