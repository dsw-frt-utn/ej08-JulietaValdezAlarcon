namespace Dsw2026Ej8.Problema5;

public class RetailSale : Sale
{
    public RetailSale(decimal amount) : base(amount) { }

    public override decimal CalculateTotal() => Amount;
}