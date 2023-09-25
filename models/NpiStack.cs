using npi_calculator.models.excpetions;

namespace npi_calculator.models;

public class NpiStack : Stack<double>
{
    public void Calculate(Func<double, double, double> operation)
    {
        if (Count < 2)
        {
            throw new NpiException($"There are not enough value ({Count})", NpiExceptionCode.NOT_ENOUGH_VALUE);
        }
        var b = Pop();
        var a = Pop();
        var result = operation(a, b);
        Push(result);
    }

    public double GetResult()
    {
        if (Count > 1)
        {
            throw new NpiException($"There are {Count} values yet", NpiExceptionCode.CALCUL_NOT_FINISHED);
        }
        else if (Count < 1)
        {
            throw new NpiException($"There are no value", NpiExceptionCode.NO_VALUE);
        }
        return Pop();
    }
}