using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Represents the repository for managing tickets crossing Storebælt
    /// </summary>
    public interface IStoreBaeltRepository
    {
        /// <summary>
        /// Adds a ticket to the repository
        /// </summary>
        /// <param name="vehicle"></param>
        void AddTicket(Vehicle vehicle);
        /// <summary>
        /// Returns all the tickets from the repository
        /// </summary>
        /// <returns></returns>
        List<Vehicle> GetTickets();
        /// <summary>
        /// Returns tickets by their license plate
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <returns></returns>
        List<Vehicle> GetTicketByLicensePlate(string licensePlate);
    }
}
