namespace Kata.Checkout;

/// <summary>
/// An implementation of the Checkout Contract
/// </summary>
public class Checkout : ICheckout
{
    public decimal Total => throw new NotImplementedException();

    public void ScanItem(string SKU)
    {
        throw new NotImplementedException();
    }
}

