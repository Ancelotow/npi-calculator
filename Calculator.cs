using npi_calculator.extensions;
using npi_calculator.models;
using npi_calculator.models.excpetions;

namespace npi_calculator;

public class Calculator
{
    public static Dictionary<string, Func<double, double, double>> Operators = new Dictionary<string, Func<double, double, double>>()
    {
        { "+", (a, b) => a + b },
        { "-", (a, b) => a - b },
        { "*", (a, b) => a * b },
        { "/", (a, b) => a / b },
        { "<", (a, b) => (a < b).ToDouble() },
        { ">", (a, b) => (a > b).ToDouble() },
        { "==", (a, b) => (a.Equals(b)).ToDouble() },
        { "!=", (a, b) => (!a.Equals(b)).ToDouble() },
        { "<=", (a, b) => (a <= b).ToDouble()  },
        { ">=", (a, b) => (a >= b).ToDouble() }
    };
    
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
                _values.Calculate(Operators[value]);
            }
        }
        
        return _values.GetResult();
    }
}