using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using Bridge;
using System;

namespace BridgeTest
{
    [TestClass]
    public class StoreBaeltRepoTesting
    {
        [TestMethod]
        public void AddTicket_ShouldIncreaseTicketCount()
        {
            //Arrange
            var repository = new StoreBaeltRepository();
            var car = new Car("CDA2134", DateTime.Now, false);
            //Act
            repository.AddTicket(car);
            //Assert
            Assert.AreEqual(1, repository.GetTickets().Count);
        }
        [TestMethod]
        public void AddTicket_ShouldAddCorrectTicket()
        {
            //Arrange
            var repository = new StoreBaeltRepository();
            var car = new Car("CDA2134", DateTime.Now, false);
            //Act
            repository.AddTicket(car);
            //Assert
            Assert.AreEqual("CDA2134", repository.GetTickets()[0].LicensePlate);
        }
        [TestMethod]
        public void GetTickets_ShouldReturnAllTickets()
        {
            //Arrange
            var repository = new StoreBaeltRepository();
            var car1 = new Car("CDA2134", DateTime.Now, false);
            var car2 = new Car("ABC1234", DateTime.Now, true);
            repository.AddTicket(car1);
            repository.AddTicket(car2);
            //Act
            var tickets = repository.GetTickets();
            //Assert
            Assert.AreEqual(2, tickets.Count);
        }
        [TestMethod]
        public void GetTicketByLicensePlate_ShouldReturnCorrectTicket()
        {
            //Arrange
            var repository = new StoreBaeltRepository();
            var car1 = new Car("CDA2134", DateTime.Now, false);
            var car2 = new Car("ABC1234", DateTime.Now, true);
            repository.AddTicket(car1);
            repository.AddTicket(car2);
            //Act
            var result = repository.GetTicketByLicensePlate("CDA2134");
            //Assert
            Assert.AreEqual("CDA2134", result[0].LicensePlate);
        }
    }
}
