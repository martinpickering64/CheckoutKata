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

    [Fact]
    public void ScanningSeveralOfAnItemWithPriceUpdatesTotal()
    {
        var checkout = new Checkout();
        checkout.ScanItem("123456");
        var unitPrice = checkout.Total;
        var expectedTotal = unitPrice * 3;

        checkout.ScanItem("123456");
        checkout.ScanItem("123456");
        var actualTotal = checkout.Total;

        Assert.Equal(expectedTotal, actualTotal);
    }

    [Fact]
    public void ScanningSeveralOfAnItemWithQuantityBreakPriceUpdatesTotal()
    {
        var checkout = new Checkout();
        checkout.ScanItem("123456");
        var unitPrice = checkout.Total;
        var straightMultiple = unitPrice * 3;

        checkout.ScanItem("123456");
        checkout.ScanItem("123456");
        var actualTotal = checkout.Total;

        Assert.NotEqual(straightMultiple, actualTotal);
    }
}
