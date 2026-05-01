namespace Dsw2026Ej8.Problema3;

public class Problema3
{
    public string CompararCopias(int originalValue, Product product)
    {
        // Copia del valor (tipo valor - se copia por valor)
        int copia = originalValue;
        copia++;

        // Copia de la referencia (tipo referencia - apunta al mismo objeto)
        Product productoCopia = product;
        productoCopia.SetDescription("Descripcion modificada");

        return $"{originalValue}-{copia}-{product.Description}";
    }
}
