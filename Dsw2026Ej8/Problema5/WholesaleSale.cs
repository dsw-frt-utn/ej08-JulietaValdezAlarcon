namespace Dsw2026Ej8.Problema5;

public class WholesaleSale : Sale
{
    private const decimal DiscountRate = 0.10m;

    public WholesaleSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal()
        => Amount * (1 - DiscountRate);
}