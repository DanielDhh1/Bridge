using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// Represents a vechicle object with stored licence plates and date data
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        public bool Brobizz { get; set; }

        /// <summary>
        /// Initializes a new instance of a vehicle with attributes
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the license plate is longer than 7 characters</exception>
        public Vehicle(string licensePlate, DateTime date, bool brobizz)
        {
            if(licensePlate.Length > 7)
            {
                throw new ArgumentOutOfRangeException("A license plate cant be longer than 7 characters.");
            }
        
            LicensePlate = licensePlate;
            Date = date;
            Brobizz = brobizz;
        }
        /// <summary>
        /// Calculates the price for crossing the bridge
        /// </summary>
        /// <returns>0 has been implemented as deafult</returns>
        public virtual double Price()
        {
            return 0;
        }
        /// <summary>
        /// Gets the type of the vehicle
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
    }
}
