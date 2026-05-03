namespace Dsw2026Ej8.Problema5;

public class Sale
{
    public decimal Amount { get; set; }

    public Sale(decimal amount)
    {
        Amount = amount;
    }

    public virtual decimal CalculateTotal() => Amount;
}