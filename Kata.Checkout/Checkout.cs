namespace Kata.Checkout;

/// <summary>
/// An implementation of the Checkout Contract
/// </summary>
public class Checkout : ICheckout
{
    private readonly List<CheckoutItem> _items;
    private readonly IPricer _pricerSvc;

    public Checkout(IPricer pricer)
    {
        _items = new List<CheckoutItem>();  
        _pricerSvc = pricer;
    }

    public decimal Total => _items.Sum(i => i.TotalValue);

    public void ScanItem(string SKU)
    {
        var item = _items.SingleOrDefault(i => i.SKU == SKU);
        if (item is null)
        {
            _items.Add(new CheckoutItem(SKU, 1, _pricerSvc.PriceItem(SKU, 1)));
            return;
        }
        var newQty = item.Quantity + 1;
        var newItem = new CheckoutItem(SKU, newQty, _pricerSvc.PriceItem(SKU, newQty));
        _items.Remove(item);
        _items.Add(newItem);
    }
}

