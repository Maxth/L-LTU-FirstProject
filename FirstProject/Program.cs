// See https://aka.ms/new-console-template for more information

List<Employee> employeeLedger = [];
string[] validActions = ["1", "2", "3"];

while (true)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine(
        "Press 1 to add an employee to the ledger. Press 2 to print out the ledger. Press 3 to exit."
    );
    string? action = Console.ReadLine();
    if (validActions.Contains(action))
    {
        switch (action)
        {
            case "1":
                while (true)
                {
                    Console.WriteLine("Enter employee name");
                    string? n = Console.ReadLine();
                    if (n != null && n.Length > 0)
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter employee wage");
                            string? w = Console.ReadLine();

                            try
                            {
                                employeeLedger.Add(new Employee(n, int.Parse(w)));
                                Console.WriteLine("Employee " + n + " added!\n");

                                //Detta var jag tvungen att googla, vanare vid Java där man kan namnge loopar
                                goto caseEnd;
                            }
                            catch
                            {
                                invalidInput();
                            }
                        }
                    }
                    else
                    {
                        invalidInput();
                    }
                }
                caseEnd:
                {
                    break;
                }
            case "2":
                Console.WriteLine("Here comes the ledger:");
                foreach (Employee employee in employeeLedger)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Name: " + employee.Name + "  Wage: " + employee.Wage);
                    Console.WriteLine("\n");
                }
                break;
            case "3":
                goto endProgram;
            default:
                break;
        }
    }
    else
    {
        invalidInput();
    }
}

endProgram: { }

static void invalidInput()
{
    Console.WriteLine("Invalid input, please try again.\n");
}

class Employee(string name, int wage)
{
    public string Name { get; set; } = name;
    public int Wage { get; set; } = wage;
}
