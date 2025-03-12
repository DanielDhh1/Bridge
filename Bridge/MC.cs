using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// This the the MC sub class that inherits from the vehicle base class
    /// </summary>
    public class MC : Vehicle
    {
        public MC(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }
        /// <summary>
        /// Calculates the price for the MC to cross the bridge
        /// The base price for a MC is 120kr
        /// If the MC has a Brobizz discount, a 10% discount is added to base price
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double basePrice = 120;
            double brobizzdiscount = 0.90;
            return Brobizz ? basePrice * brobizzdiscount : basePrice;
        }
        /// <summary>
        /// Gets the type of vehicle
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
