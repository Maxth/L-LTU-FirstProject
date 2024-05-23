public class EmployeeRegistry
{
    private List<Employee> _registry;
    private IConsoleUI _cUI;

    public EmployeeRegistry(IConsoleUI CUI)
    {
        _cUI = CUI;
        _registry = new List<Employee>();
    }

    public void PrintRegistry()
    {
        foreach (var employee in _registry)
        {
            _cUI.Write(employee.ToString());
        }
    }

    public void AddEmployee(string name, int wage)
    {
        _registry.Add(new Employee(name, wage));
    }

    public int GetEmployeeCount()
    {
        return _registry.Count;
    }
}
