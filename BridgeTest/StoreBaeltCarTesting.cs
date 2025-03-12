using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary; 
using Bridge;

namespace BridgeTest
{
    [TestClass]
    public class StoreBaeltCarTesting
    {
        [TestMethod]
        public void StoreBaeltCar_PriceWithBrobizzAndPriceWeekend_ReturnCorrectPrice()
        {
            //Arrange
            var car = new StoreBaeltCar("ABC1234", new DateTime(2024, 05, 11), true);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(175.95, price, 0.01);
        }
        [TestMethod]
        public void StoreBaeltCar_PriceWithoutBrobizzAndPriceWeekend_ReturnCorrectPrice()
        {
            //Arrange
            var car = new StoreBaeltCar("ABC4321", new DateTime(2024, 06, 23), false);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(195.5, price, 0.01);
        }
    }
}
