namespace Dsw2026Ej8.Problema1;

public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        string formattedPrice = FormatearPrecio(price);
        return $"[{code}] {description} - {formattedPrice}";
    }
}
