namespace Dsw2026Ej8.Problema6;

public static class Extensions
{
    public static string ToProductCode(this string? code)
    {
        if (code == null)
            return "SIN-CODIGO";

        return code
            .Trim()
            .ToUpper()
            .Replace(" ", "-");
    }
}
