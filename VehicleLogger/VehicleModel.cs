using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogger
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Fuel { get; set; }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }
    }
}
