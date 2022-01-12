namespace Kata.Checkout.UnitTest;
using Xunit;
using Moq;

/// <summary>
/// A collection of tests focused on the behaviour of the Checkout Total
/// </summary>
public class CheckoutTotalTests
{
    [Fact]
    public void ScanningAnItemWithPriceUpdatesTotal()
    {
        var mock = new Mock<IPricer>();
        mock.Setup(p => p.PriceItem(It.IsAny<string>(), It.IsAny<uint>())).Returns(10.54M);
        IPricer pricer = mock.Object;
        var checkout = new Checkout(pricer);
        var initialTotal = checkout.Total;
        checkout.ScanItem("123456");

        var actualTotal = checkout.Total;

        Assert.NotEqual(initialTotal, actualTotal);
    }

    [Fact]
    public void ScanningSeveralOfAnItemWithPriceUpdatesTotal()
    {
        const decimal unitPrice = 10.54M;
        const decimal expectedTotal = 3.00M * unitPrice;
        var mock = new Mock<IPricer>();
        mock.Setup(p => p.PriceItem(It.IsAny<string>(), 3)).Returns(expectedTotal);
        IPricer pricer = mock.Object;
        var checkout = new Checkout(pricer);
        checkout.ScanItem("123456");
        checkout.ScanItem("123456");
        checkout.ScanItem("123456");

        var actualTotal = checkout.Total;

        Assert.Equal(expectedTotal, actualTotal);
    }

    [Fact]
    public void ScanningSeveralOfAnItemWithQuantityBreakPriceUpdatesTotal()
    {
        const string testSku = "123456";
        const decimal qbtPrice = 2.50M * 10.54M;
        var mock = new Mock<IPricer>();
        mock.Setup(p => p.PriceItem(testSku, 3)).Returns(qbtPrice);
        IPricer pricer = mock.Object;
        var checkout = new Checkout(pricer);
        checkout.ScanItem(testSku);
        checkout.ScanItem(testSku);
        checkout.ScanItem(testSku);

        var actualTotal = checkout.Total;

        Assert.Equal(qbtPrice, actualTotal);
    }
}
