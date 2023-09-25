using npi_calculator;
using npi_calculator.extensions;

static class Program
{
    [STAThread]
    public static void Main()
    {
        var operation = "2 5 6 + * 22 ==";
        var calculator = new Calculator(operation);
        Console.WriteLine(calculator.Calculate());
    }
}