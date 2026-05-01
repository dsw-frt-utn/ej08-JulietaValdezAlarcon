using System.Globalization;

namespace Dsw2026Ej8.Problema1;

public partial class ProductHelper
{
    private const string CurrencyCulture = "es-AR";

    private string FormatearPrecio(decimal price)
    {
        CultureInfo culture = new CultureInfo(CurrencyCulture);
        return price.ToString("C", culture);
    }
}
