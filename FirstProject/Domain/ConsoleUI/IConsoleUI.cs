public interface IConsoleUI
{
    void Write(string msg);

    string Read();
}

public interface IMockConsoleUI : IConsoleUI
{
    public string SetInput { get; set; }
}
