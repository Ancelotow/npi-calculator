namespace npi_calculator;

public class Operator
{
    public string Symbol { get; }
    public Func<double, double, double> Operation { get; private set; }
    public bool IsPriority { get; }

    public Operator(string symbol, Func<double, double, double> operation, bool isPriority)
    {
        Symbol = symbol;
        Operation = operation;
        IsPriority = isPriority;
    }
}