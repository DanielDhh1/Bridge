using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using OresundBronTicketLibrary;
using Microsoft.VisualBasic;

namespace BridgeTest
{
    [TestClass]
    public class OresundTesting
    {
        [TestMethod]
        public void OresundCar_Price_WithoutBrobizz_ShouldReturnCorrectPrice()
        {
            //Arrange
            var car = new OresundCar("ABC1234", DateTime.Now, false);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(460, price);
        }
        [TestMethod]
        public void OresundCar_Price_WithBrobizz_ShouldReturnCorrectPrice()
        {
            //Arrange
            var car = new OresundCar("ABC1234", DateTime.Now, true);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(178, price);
        }
        [TestMethod]
        public void OresundCar_VehicleType_ShouldReturnOresundCar()
        {
            //Arrange
            var car = new OresundCar("ABC1234", DateTime.Now, false);
            //Act
            string vehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Oresund Car", vehicleType);
        }
        [TestMethod]
        public void OresundMC_Price_WithoutBrobizz_ShouldReturnCorrectPrice()
        {
            //Arrange
            var mc = new OresundMC("CBA4321", DateTime.Now, false);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(235, price);
        }
        [TestMethod]
        public void OresundMC_Price_WithBrobizz_ShouldReturnCorrectPrice()
        {
            //Arrange
            var mc = new OresundMC("CBA4321", DateTime.Now, true);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(92, price);
        }
        [TestMethod]
        public void OresundMC_VehicleType_ShouldReturnOresundMC()
        {
            //Arrange
            var mc = new OresundMC("CBA4321", DateTime.Now, false);
            //Act
            string vehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }
    }
}
