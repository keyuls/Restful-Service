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
        [OperationContract]
        [WebInvoke(UriTemplate = "*", Method = "*")]
        void HandleHttpOptionsRequest();

        [WebGet(ResponseFormat=WebMessageFormat.Json, UriTemplate = "/vehicles")]
        [OperationContract]
        List<Vehicle> GetVehicle();

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/vehicles/{id}")]
        [OperationContract]
        Vehicle getVehicleById(String id);

        [WebInvoke(Method = "PUT", UriTemplate = "/vehicles")]
        [OperationContract]
        void updateVehicle(Vehicle vehicle);

        [WebInvoke(Method = "POST", ResponseFormat=WebMessageFormat.Json, UriTemplate = "/vehicles")]
        [OperationContract]
        Vehicle createVehicle(Vehicle vehicle);

        [WebInvoke(Method = "DELETE", UriTemplate = "/vehicles/{id}")]
        [OperationContract]
        void deleteVehicle( String id);


        
    }
}
