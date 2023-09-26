namespace npi_calculator.extensions;

internal static class StringExtension
{
    public static bool IsDigit(this string value) => Int32.TryParse(value, out int j);

    public static bool IsOperator(this string value) => Operators.Values.ContainsKey(value);
}