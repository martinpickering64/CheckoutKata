namespace Kata.Checkout.UnitTest;
using Xunit;

/// <summary>
/// A collection of tests focused on the behaviour of the Checkout Total
/// </summary>
public class CheckoutTotalTests
{
    [Fact]
    public void ScanningAnItemWithPriceUpdatesTotal()
    {
        var checkout = new Checkout();
        var initialTotal = checkout.Total;
        checkout.ScanItem("123456");

        var actualTotal = checkout.Total;

        Assert.NotEqual(initialTotal, actualTotal);
    }
}
