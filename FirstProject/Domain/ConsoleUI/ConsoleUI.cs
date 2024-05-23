class ConsoleUI : IConsoleUI
{
    public void Write(string msg)
    {
        Console.WriteLine(msg);
    }

    public string Read()
    {
        return Console.ReadLine() ?? "";
    }
}

class MockConsoleUI : IConsoleUI
{
    public string SetReadInput { get; set; } = "3";

    public string Read()
    {
        return SetReadInput;
    }

    public void Write(string msg)
    {
        Console.WriteLine(msg);
    }
}
