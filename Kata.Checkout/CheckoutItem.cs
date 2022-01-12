namespace Kata.Checkout;

public record CheckoutItem
{
    public CheckoutItem(string sku, uint qty, decimal totalValue)
    {
        SKU = sku;
        Quantity = qty;
        TotalValue = totalValue;
    }
    public string SKU;
    public uint Quantity;
    public decimal TotalValue;
}
