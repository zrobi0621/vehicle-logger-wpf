using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLogger
{
    public class SQLiteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //LOAD

        public static List<VehicleModel>LoadVehicles()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<VehicleModel>("SELECT * FROM Vehicle", new DynamicParameters());
                return output.ToList();
            }
        }


         public static List<FuelModel>LoadFuels()
         {
             using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
             {
                 var output = cnn.Query<FuelModel>("SELECT * FROM Fuel", new DynamicParameters());
                 return output.ToList();
             }
         }

        //ADD

        public static void AddVehicle(VehicleModel vehicle)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT INTO Vehicle (Make, Model, Engine, Fuel) VALUES (@Make, @Model, @Engine, @Fuel)", vehicle);
            }
        }


    }
}
