namespace Kata.Checkout;

/// <summary>
/// An implementation of the Checkout Contract
/// </summary>
public class Checkout : ICheckout
{
    private readonly List<CheckoutItem> _items;

    public Checkout()
    {
        _items = new List<CheckoutItem>();  
    }

    public decimal Total => _items.Sum(i => i.TotalValue);

    public void ScanItem(string SKU)
    {
        _items.Add(new CheckoutItem(SKU, 1, 10.00M));
    }
}

