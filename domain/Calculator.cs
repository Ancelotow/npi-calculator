using npi_calculator.extensions;
using npi_calculator.models;

namespace npi_calculator;

public class Calculator
{
    public string Operation { get; }
    private NpiStack _values { get; } = new NpiStack();

    public Calculator(string operation)
    {
        Operation = operation;
    }

    public double Calculate()
    {
        var values = Operation.Split(" ");
        foreach (var value in values)
        {
            if (value.IsDigit())
            {
                _values.Push(Double.Parse(value));
            }
            else if(value.IsOperator())
            {
                _values.Calculate(Operators.Values[value]);
            }
        }
        return _values.GetResult();
    }
}