public class Main
{
    private IConsoleUI _cUI;
    private IEmployeeRegistry _employeeRegistry;

    public Main(IConsoleUI CUI)
    {
        _cUI = CUI;
        _employeeRegistry = new EmployeeRegistry(_cUI);
    }

    public void Run()
    {
        SeedData();
        while (true)
        {
            _cUI.Write("What do you want to do?");
            _cUI.Write(
                "Press 1 to add an employee to the registry. Press 2 to print out the registry. Press 3 to exit."
            );
            string action = _cUI.Read();

            switch (action)
            {
                case "1":
                    string name = ReceiveEmployeeName();
                    int wage = ReceiveEmployeeWage();
                    _employeeRegistry.AddEmployee(name, wage);
                    _cUI.Write($"Employee {name} successfully added to registry!\n");
                    break;
                case "2":
                    _employeeRegistry.PrintRegistry();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    GiveFeedbackForInvalidInput();
                    break;
            }
        }
    }

    public int ReceiveEmployeeWage()
    {
        while (true)
        {
            _cUI.Write("Enter the new employee's wage:");
            string wage = _cUI.Read();
            //Validate the wage is an int
            if (int.TryParse(wage, out int intWage) && intWage > 0)
            {
                return intWage;
            }
            else
            {
                GiveFeedbackForInvalidInput();
            }
        }
    }

    public string ReceiveEmployeeName()
    {
        while (true)
        {
            _cUI.Write("Enter the new employee's name:");
            string name = _cUI.Read();
            //Validate the name contains letters and possibly whitespace.
            if (name.Split(" ").All(subString => subString.All(Char.IsLetter)))
            {
                return name;
            }
            else
            {
                GiveFeedbackForInvalidInput();
            }
        }
    }

    void SeedData()
    {
        _employeeRegistry.AddEmployee("Kalle", 40000);
        _employeeRegistry.AddEmployee("Stina", 40000);
        _employeeRegistry.AddEmployee("Nisse", 60000);
    }

    void GiveFeedbackForInvalidInput()
    {
        _cUI.Write("Invalid input, please try again.\n");
    }
}
