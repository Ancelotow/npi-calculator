using npi_calculator.extensions;
using npi_calculator.models;

namespace npi_calculator;

public class Converter
{
    public string Operation { get; private set; }
    private NpiConverterStack _values { get; } = new NpiConverterStack();

    public Converter(string operation)
    {
        Operation = operation;
    }
    
    public string Convert()
    {
        var values = Operation.Split(" ");
        foreach (var value in values)
        {
            if (value.IsDigit())
            {
                _values.Push(value);
            }
            else if(value.IsOperator())
            {
                _values.PushOperation(Operators.Values[value]);
            }
        }
        return _values.GetResult();
    }
}