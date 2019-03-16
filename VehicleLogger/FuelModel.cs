using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogger
{
    public class FuelModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public float Amount { get; set; }
        public int Cost { get; set; }
        public int Mileage { get; set; }
        public string Date { get; set; }

        public FuelModel()
        {

        }

        public FuelModel(int carId, float amount, int cost, int mileage, string date)
        {
            CarId = carId;
            Amount = amount;
            Cost = cost;
            Mileage = mileage;
            Date = date;
        }

        public override string ToString()
        {
            return $"{CarId} {Amount} {Cost} {Mileage} {Date}";
        }
    }
}
