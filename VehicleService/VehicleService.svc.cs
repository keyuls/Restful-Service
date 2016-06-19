using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VehicleServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class VehicleService : IVehicleService
    {
        public static int idGen = 100;
        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public List<Vehicle> GetVehicle()
        {
            return vehicleList;
        }

        public Vehicle getVehicleById(string id)
        {
           Vehicle result = vehicleList.Find(x => x.Id == Int32.Parse(id));
           return result;
        }

        public void updateVehicle(Vehicle vehicle)
        {
            if (!IsEmpty(vehicle.Make) && !IsEmpty(vehicle.Model) && yearRange(vehicle.Year))
            {
                vehicleList.Remove(vehicleList.Where(x => x.Id == vehicle.Id).First());
                vehicleList.Add(vehicle);
            }
        }

        public Vehicle createVehicle(Vehicle vehicle)
        {
            if (!IsEmpty(vehicle.Make) && !IsEmpty(vehicle.Model) && yearRange(vehicle.Year))
            { 
                idGen = idGen + 1;
                vehicle.Id = idGen;
                vehicleList.Add(vehicle);          
            }
            return vehicle;
        }

        public void deleteVehicle(string id)
        {
            vehicleList.Remove( vehicleList.Where( x => x.Id == Int32.Parse(id)).First());
        }

        public void HandleHttpOptionsRequest()
        {
        }

        public Boolean yearRange(int year) {
            if (year >= 1950 && year <= 2050) 
                return true; 
            else
                return false;
        }

        public Boolean IsEmpty(String str) {
                return String.IsNullOrEmpty(str);
        }


        public List<Vehicle> GetVehicleByMakeModel(string model, string make)
        {
           return vehicleList.FindAll(x => x.Model == model && x.Make == make);
        }

        public List<Vehicle> GetVehicleByModelYear(string model, string year)
        {
            return vehicleList.FindAll(x => x.Model == model && x.Year == Int32.Parse(year));
        }

        public List<Vehicle> GetVehicleByMakeYear(string make, string year)
        {
            return vehicleList.FindAll(x => x.Make == make && x.Year == Int32.Parse( year));
        }

    }
}
