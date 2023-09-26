using npi_calculator.models.excpetions;

namespace npi_calculator.models;

public class NpiConverterStack : Stack<string>
{
    public void PushOperation(Operator op)
    {
        if (Count < 2)
        {
            throw new NpiException($"There are not enough value ({Count})", NpiExceptionCode.NOT_ENOUGH_VALUE);
        }
        var b = Pop();
        var a = Pop();
        var operation = op.IsPriority ? $"{a} {op.Symbol} {b}" : $"({a} {op.Symbol} {b})";
        Push(operation);
    }
    
    public string GetResult()
    {
        if (Count > 1)
        {
            throw new NpiException($"There are {Count} values yet", NpiExceptionCode.CALCUL_NOT_FINISHED);
        }
        else if (Count < 1)
        {
            throw new NpiException($"There are no value", NpiExceptionCode.NO_VALUE);
        }
        var result = Pop();
        if (result[0] == '(' && result.Last() == ')')
        {
            result = result.Substring(1, result.Length - 2);
        }

        return result;
    }
}