namespace npi_calculator.extensions;

internal static class BooleanExtension
{
    public static double ToDouble(this bool value) => value ? 1.0 : 0.0;
}