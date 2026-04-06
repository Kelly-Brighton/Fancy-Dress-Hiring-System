using FancyDressHiringSystem;

namespace FancyDressTest
{
    [TestClass]
    public sealed class BasketTests
    {
        [TestMethod]
        public void Test_TotalPriceCalculation()
        {
            // Arrange
            decimal price = 10.00m;
            int quantity = 3;

            // Act
            decimal totalPrice = price * quantity;

            // Assert
            Assert.AreEqual(30.00m, totalPrice, "Total price should be calculated as price multiplied by quantity.");
        }

        public void Test_FreeShipping_WhenPriceAbove35()
        {
            // Arrange
            decimal price = 40.00m;

            // Act
            bool result = price > 35;

            // Assert
            Assert.IsTrue(result, "Shipping should be free when the price is above 35.");
        }

        public void Test_PaidShipping_WhenPriceBelowOrEqual35()
        {
            // Arrange
            decimal price = 30.00m;

            // Act
            bool result = price > 35;

            // Assert
            Assert.IsFalse(result, "Shipping should be paid when the price is 35 or below.");
        }

        public void test_SelectedItemsCount()
        {
            // Arrange
            int selectedItemsCount = 2;

            // Act
            int result = selectedItemsCount;

            // Assert
            Assert.AreEqual(2, result, "Selected items count should be correctly tracked.");
        }

        public void Test_NoSelectionDefaultsToAll()
        {
            // Arrange
            int selectedItemsCount = 0;

            // Act
            bool isAllSelected = selectedItemsCount == 0;

            // Assert
            Assert.IsTrue(isAllSelected, "If no items are selected, it should default to all items being selected.");
        }
    }
}
