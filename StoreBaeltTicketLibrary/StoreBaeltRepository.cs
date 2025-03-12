using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents a repo for managing ticket for vehicles crossing Storebælt
    /// Implements the IStoreBaeltRepositiry interface
    /// </summary>
    public class StoreBaeltRepository : IStoreBaeltRepository
    {
        private readonly List<Vehicle> _tickets;

        public StoreBaeltRepository()
        {
            _tickets = new();
        }
        public void AddTicket(Vehicle vehicle)
        {
            _tickets.Add(vehicle);

        }
        public List<Vehicle> GetTickets()

        {
            return _tickets;
        }
        public List<Vehicle> GetTicketByLicensePlate(string licensePlate)
        {
            return _tickets.Where(v => v.LicensePlate == licensePlate).ToList();
        }
    }
}
