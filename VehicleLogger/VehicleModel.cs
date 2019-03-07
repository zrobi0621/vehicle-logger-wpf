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
        public string Brand { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"{Brand} {Type}";
        }
    }
    
}
