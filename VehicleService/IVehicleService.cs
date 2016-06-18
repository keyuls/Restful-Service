using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace VehicleServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IVehicleService
    {
        [WebGet(UriTemplate = "vehicles/")]
        [OperationContract]
        List<Vehicle> GetVehicle();

        [WebGet(UriTemplate = "vehicles/{id}")]
        [OperationContract]
        Vehicle getVehicleById();

        [WebInvoke(Method = "PUT", UriTemplate = "vehicles/")]
        [OperationContract]
        void updateVehicle();

        [WebInvoke(Method = "POST", UriTemplate = "vehicles/")]
        [OperationContract]
        Vehicle createVehicle();

        [WebInvoke(Method = "DELETE", UriTemplate = "vehicle/{id}")]
        [OperationContract]
        void deleteVehicle();


        
    }
}
