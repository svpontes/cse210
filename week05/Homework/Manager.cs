// Classe derivada (filho) que herda de Funcionario
public class Manager : Employee
{
    private double _bonus; // Bônus do gerente (privado)

    // Construtor que chama o construtor da classe base
    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        _bonus = bonus;
    }

    // Método para obter o bônus do gerente
    public double GetBonus()
    {
        return _bonus;
    }

    // Método para exibir as informações do gerente (incluindo o bônus)
    public void DisplayDataAndBonus()
    {
        Console.WriteLine($"Nome: {GetName()}, Salário: {GetSalary():C}, Bônus: {_bonus:C}");
    }
}
