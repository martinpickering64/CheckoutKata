namespace Kata.Checkout.UnitTest;
using Xunit;

/// <summary>
/// A set of tests focused on the behaviour of item scanning
/// </summary>
public class ItemScanningTests
{
    [Fact]
    public void CanScanAnItem()
    {
        var checkout = new Checkout();

        checkout.ScanItem("123456");
    }
}
