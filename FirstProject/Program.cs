// See https://aka.ms/new-console-template for more information


EmployeeRegistry employeeRegistry = new EmployeeRegistry();
SeedData();

while (true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine(
        "Press 1 to add an employee to the registry. Press 2 to print out the registry. Press 3 to exit."
    );
    string? action = Console.ReadLine();

    if (action == "3")
    {
        break;
    }

    switch (action)
    {
        case "1":
            string name = ReceiveEmployeeName();
            int wage = ReceiveEmployeeWage();
            employeeRegistry.AddEmployee(name, wage);
            Console.WriteLine($"Employee {name} succesfully added to registry!\n");
            break;
        case "2":
            employeeRegistry.PrintRegistry();
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
        Console.WriteLine("Enter the new employee's wage:");
        string? wage = Console.ReadLine();
        //Validate the wage is an int
        if (int.TryParse(wage, out int intWage))
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
        Console.WriteLine("Enter the new employee's name:");
        string? name = Console.ReadLine();
        //Validate the name is not null and consists of only letters
        if (name != null && name.All(Char.IsLetter))
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

static void GiveFeedbackForInvalidInput()
{
    Console.WriteLine("Invalid input, please try again.\n");
}
