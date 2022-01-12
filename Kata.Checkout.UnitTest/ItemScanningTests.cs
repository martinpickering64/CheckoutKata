namespace Kata.Checkout.UnitTest;
using Xunit;

/// <summary>
/// A set of tests focused on the behaviour of item scanning
/// </summary>
/// <remarks>One issue relating to the Checkout.ScanItem method 
/// is it is not in itself very testable. In respect of this simple 
/// Kata it probably does not matter. But as things grow beyond the 
/// present scope the lack of testability could become a headache.</remarks>
public class ItemScanningTests
{
    [Fact]
    public void CanScanAnItem()
    {
        var checkout = new Checkout();

        checkout.ScanItem("123456");
    }

    [Fact]
    public void CanScanMultipleOfTheSameItem()
    {
        var checkout = new Checkout();

        checkout.ScanItem("123456");
        checkout.ScanItem("123456");
    }

    [Fact]
    public void CanScanMultipleDifferentItems()
    {
        var checkout = new Checkout();

        checkout.ScanItem("123456");
        checkout.ScanItem("789012");
    }

}
