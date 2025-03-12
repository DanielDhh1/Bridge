using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// This is the OresundCar class that inherits from the Vehicle base class
    /// </summary>
    public class OresundCar : Vehicle
    {
        public OresundCar(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
            if(Brobizz)
            {
                return 178.0;
            }
            else
            {
                return 460.0;
            }
        }
        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
