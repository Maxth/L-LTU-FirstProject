class Employee(string name, int wage)
{
    public string Name { get; set; } = name;
    public int Wage { get; set; } = wage;

    public override string ToString()
    {
        return $"Name: {Name} Wage: {Wage}";
    }
}
