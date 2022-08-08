using System;
using System.Collections.Generic;
using System.Text;

namespace yazlab11
{
   internal class Locations
    {
        internal static Locations result;
        public string IDCargo { get; set; }
        public string NameCargo { get; set; }
        public string TypeCargo { get; set; }
        public string StatusCargo { get; set; }
        public string AddressCargo { get; set; }
        public double LatitudeCargo { get; set; }
        public double LongitudeCargo { get; set; }
        public double BeeDistance { get; set; }
    }
}
