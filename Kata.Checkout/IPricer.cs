namespace Kata.Checkout;

/// <summary>
/// The contract for an Item Pricing Service
/// </summary>
public interface IPricer
{
    /// <summary>
    /// Price an Item.
    /// </summary>
    /// <param name="sku">The SKU of the Item to be priced</param>
    /// <param name="qty">The number of the Items so that quantity break pricing can be evaluated</param>
    /// <returns>The total price for all of the Items</returns>
    decimal PriceItem(string sku, uint qty);
}
