class Employee(string name, int wage)
{
    private string Name { get; set; } = name;
    private int Wage { get; set; } = wage;

    public override string ToString()
    {
        return $"Name: {Name} Wage: {Wage}";
    }
}
