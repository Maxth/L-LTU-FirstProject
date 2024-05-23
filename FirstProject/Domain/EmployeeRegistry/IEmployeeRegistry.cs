public interface IEmployeeRegistry
{
    void PrintRegistry();

    void AddEmployee(string name, int wage);

    int GetEmployeeCount();
}
