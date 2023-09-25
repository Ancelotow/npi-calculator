namespace npi_calculator.models;

public class NpiStack : Stack<double>
{
    public void Calculate(Func<double, double, double> operation)
    {
        var b = Pop();
        var a = Pop();
        var result = operation(a, b);
        Push(result);
    }
}