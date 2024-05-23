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

public class MockConsoleUI : IMockConsoleUI
{
    public string SetInput { get; set; } = "3";

    public string Read()
    {
        return SetInput;
    }

    public void Write(string msg)
    {
        Console.WriteLine(msg);
    }
}
