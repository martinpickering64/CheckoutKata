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

    public decimal Total => throw new NotImplementedException();

    public void ScanItem(string SKU)
    {
        _items.Add(new CheckoutItem(SKU, 1, 0.00M));
    }
}

