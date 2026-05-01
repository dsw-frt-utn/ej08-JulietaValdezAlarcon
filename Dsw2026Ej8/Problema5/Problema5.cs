namespace Dsw2026Ej8.Problema5;

public abstract class Sale
{
    public decimal Amount { get; set; }

    protected Sale(decimal amount)
    {
        Amount = amount;
    }

    public virtual decimal CalculateTotal()
    {
        return Amount;
    }
}

public class RetailSale : Sale
{
    public RetailSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal()
    {
        // Sin descuento
        return Amount;
    }
}

public class WholesaleSale : Sale
{
    private const decimal DiscountRate = 0.10m;

    public WholesaleSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal()
    {
        // 10% de descuento
        return Amount - (Amount * DiscountRate);
    }
}

public class Problema5
{
    public decimal ObtenerImporteFinal(Sale sale)
    {
        return sale.CalculateTotal();
    }
}
