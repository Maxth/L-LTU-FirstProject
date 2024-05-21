class EmployeeRegistry
{
    private List<Employee> Registry = new List<Employee>();

    public void PrintRegistry()
    {
        foreach (var employee in Registry)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    public void AddEmployee(string name, int wage)
    {
        Registry.Add(new Employee(name, wage));
    }
}
