using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Bridge;

namespace OresundBronTicketLibrary
{
    /// <summary>
    /// This is the OresundMC class that inherits from the Vehicle base class
    /// </summary>
    public class OresundMC : Vehicle
    {
        public OresundMC(string licensePlate, DateTime date, bool brobizz) : base(licensePlate, date, brobizz)
        {
        }

        public override double Price()
        {
           if(Brobizz)
            {
                return 92.0;
            }
            else
            {
                return 235.0;
            }
        }
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
