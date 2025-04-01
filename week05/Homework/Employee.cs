// Classe base (pai)
public class Employee
{
    private string _name;  // Nome do funcionário (privado)
    private double _salary;  // Salário do funcionário (privado)

    // Construtor para inicializar o funcionário
    public Employee(string name, double salary)
    {
        _name = name;
        _salary = salary;
    }

    // Método público para obter o nome (somente leitura)
    public string GetName()
    {
        return _name;
    }

    // Método público para obter o salário (somente leitura)
    public double GetSalary()
    {
        return _salary;
    }

    // Método público para exibir as informações do funcionário
    public void DisplayData()
    {
        Console.WriteLine($"Nome: {_name}, Salário: {_salary:C}");
    }
}
