// See https://aka.ms/new-console-template for more information
IConsoleUI CUI = new ConsoleUI();
EmployeeRegistry employeeRegistry = new EmployeeRegistry();
SeedData();

while (true)
{
    CUI.Write("What do you want to do?");
    CUI.Write(
        "Press 1 to add an employee to the registry. Press 2 to print out the registry. Press 3 to exit."
    );
    string action = CUI.Read();

    switch (action)
    {
        case "1":
            string name = ReceiveEmployeeName();
            int wage = ReceiveEmployeeWage();
            employeeRegistry.AddEmployee(name, wage);
            CUI.Write($"Employee {name} successfully added to registry!\n");
            break;
        case "2":
            employeeRegistry.PrintRegistry();
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            GiveFeedbackForInvalidInput();
            break;
    }
}

int ReceiveEmployeeWage()
{
    while (true)
    {
        CUI.Write("Enter the new employee's wage:");
        string wage = CUI.Read();
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

string ReceiveEmployeeName()
{
    while (true)
    {
        CUI.Write("Enter the new employee's name:");
        string name = CUI.Read();
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
    employeeRegistry.AddEmployee("Kalle", 40000);
    employeeRegistry.AddEmployee("Stina", 40000);
    employeeRegistry.AddEmployee("Nisse", 60000);
}

void GiveFeedbackForInvalidInput()
{
    CUI.Write("Invalid input, please try again.\n");
}
