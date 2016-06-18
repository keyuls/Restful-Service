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

        public List<Vehicle> GetVehicle()
        {
            throw new NotImplementedException();
            /*get list of vehicle and return */
        }

        public Vehicle getVehicleById()
        {
            throw new NotImplementedException();
            /* find vehicle by id and return*/
        }

        public void updateVehicle()
        {
            throw new NotImplementedException();
            /*update vehicle*/
        }

        public Vehicle createVehicle()
        {
            throw new NotImplementedException();
            /*Create new vehicle object and store*/
        }

        public void deleteVehicle()
        {
            throw new NotImplementedException();
            /*remove vehicle*/
        }
    }
}
