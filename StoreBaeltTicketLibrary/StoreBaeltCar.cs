using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        /// <summary>
        /// Represents a car class for the storebælt ticket system
        /// Inherits from the Car base class
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        /// <param name="brobizz"></param>
        public StoreBaeltCar(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }
        /// <summary>
        /// Calculates the price for crossing the Storebælt bridge with a car.
        /// Applies a 15% discount on weekends and a 10% discount if Brobizz is used.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double basePrice = 230;
            double weekendDiscount = 0.85;
            double brobizzDiscount = 0.9;

            if(Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= weekendDiscount;
            }
            if(Brobizz)
            {
                basePrice *= brobizzDiscount;
            }
            return basePrice;
        }
    }
}
