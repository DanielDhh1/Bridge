using Bridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BridgeTest

{
    [TestClass]
    public class CarAndMCTesting
    {
        [TestMethod]
        public void Price_WithoutBrobizz_ReturnBasePriceCar()
        {
            //Arrange
            var car = new Car("ABC1234", DateTime.Now, false);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(230.00, price, 0.01);
        }
        [TestMethod]
        public void VehicleType_ForCar_ReturnsCar()
        {
            //Arrange
            var car = new Car("ABC1262", DateTime.Now, false);
            //Act
            string vehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", vehicleType);
        }
        [TestMethod]
        public void Price_WithBrobizzDiscount_ReturnDiscountedPrice_ForCar()
        {
            //Arrange
            var car = new Car("CKD1234", DateTime.Now, true);
            //Act
            double price = car.Price();
            //Assert
            Assert.AreEqual(207.00, price, 0.01);
        }
        [TestMethod]
        public void Price_WithoutBrobizz_ReturnBasePriceMC()
        {
            //Arrange
            var mc = new MC("CBA4321", DateTime.Now, false);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(120.00, price, 0.01);
        }
        [TestMethod]
        public void VehicleType_ForMC_ReturnsMC()
        {
            //Arrange
            var mc = new MC("ABCD123", DateTime.Now, false);
            //Act
            string vehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", vehicleType);
        }
        [TestMethod]
        public void Price_WithBrobizzDiscount_ReturnDiscountedPrice_ForMC()
        {
            //Arrange
            var mc = new MC("ODN9482", DateTime.Now, true);
            //Act
            double price = mc.Price();
            //Assert
            Assert.AreEqual(108.00, price, 0.01);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithLongLicensePlate_ThrowException()
        {
            //Arrange
            string invalidLicensePlate = "ABCDEFG123";
            DateTime date = DateTime.Now;
            bool brobizz = false;
            //Act
            var car = new Car(invalidLicensePlate, date, brobizz);
            //Arrange is getting handled by the ExpectedException attribute
        }


    }
}