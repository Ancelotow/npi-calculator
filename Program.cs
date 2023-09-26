using npi_calculator;

static class Program
{
    [STAThread]
    public static void Main()
    {
        string operation = "13 12 - 20 26 * *";
        var calculator = new Calculator(operation);
        var converter = new Converter(operation);
        Console.WriteLine(operation);
        Console.WriteLine("Result : " + calculator.Calculate());
        Console.WriteLine("Algébrique : " + converter.Convert());
        
        Console.WriteLine("\n===============================\n");

        operation = "230 653748 * 7830 + 5 / 673 -";
        var calculatorBis = new Calculator(operation);
        var converterBis = new Converter(operation);
        Console.WriteLine(operation);
        Console.WriteLine("Result : " + calculatorBis.Calculate());
        Console.WriteLine("Algébrique : " + converterBis.Convert());

        Console.WriteLine("\n===============================\n");

        operation = "3 4 7 + *";
        var calculatorTer = new Calculator(operation);
        var converterTer = new Converter(operation);
        Console.WriteLine(operation);
        Console.WriteLine("Result : " + calculatorTer.Calculate());
        Console.WriteLine("Algébrique : " + converterTer.Convert());
    }
}