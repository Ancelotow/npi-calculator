using npi_calculator.extensions;

namespace npi_calculator;

public static class Operators
{
    public static Dictionary<string, Operator> Values { get; } = new Dictionary<string, Operator>()
    {
        { "+", new Operator("+", (a, b) => a + b, false) },
        { "-", new Operator("-", (a, b) => a - b, false) },
        { "*", new Operator("*", (a, b) => a * b, true) },
        { "/", new Operator("/", (a, b) => a / b, true) },
        { "<", new Operator("<", (a, b) => (a < b).ToDouble(), false) },
        { ">", new Operator(">", (a, b) => (a > b).ToDouble(), false) },
        { "==", new Operator("==", (a, b) => (a.Equals(b)).ToDouble(), false) },
        { "!=", new Operator("!=", (a, b) => (!a.Equals(b)).ToDouble(), false) },
        { "<=", new Operator("+", (a, b) => (a <= b).ToDouble(), false) },
        { ">=", new Operator("+", (a, b) => (a >= b).ToDouble(), false) }
    };
}