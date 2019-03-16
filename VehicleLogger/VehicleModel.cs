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
        public string Engine { get; set; }
        public string Fuel { get; set; }

        public VehicleModel()
        {

        }

        public VehicleModel(string make, string model, string engine, string fuel)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Fuel = fuel;
        }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }
    }
}
