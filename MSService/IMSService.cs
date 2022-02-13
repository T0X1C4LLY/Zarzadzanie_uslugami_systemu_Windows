using System.Collections.Generic;
using System.ServiceModel;

namespace MSService {

    [ServiceKnownType(typeof(string))]
    [ServiceKnownType(typeof(string[]))]
    [ServiceContract(Namespace = "http://MSService")]
    public interface IMSService {

        [OperationContract]
        void StartService(string displayName);

        [OperationContract]
        void StopService(string displayName);

        [OperationContract]
        List<string> ListAllServices();

        [OperationContract]
        string GetServiceName(string service);

        [OperationContract]
        string GetServiceType(string service);

        [OperationContract]
        string GetServiceStartType(string service);

        [OperationContract]
        string GetServiceStatus(string service);
    }
}
