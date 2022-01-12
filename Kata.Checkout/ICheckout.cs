namespace Kata.Checkout;

/// <summary>
/// The public contract for the Checkout
/// </summary>
public interface ICheckout
{
    /// <summary>
    /// Declare that an additional Item has been scanned and added to the checkout session
    /// </summary>
    /// <param name="SKU">The SKU of the item scanned</param>
    void ScanItem(string SKU);
    /// <summary>
    /// The Grand Total cost of the checkout session
    /// </summary>
    decimal Total { get; }
}
