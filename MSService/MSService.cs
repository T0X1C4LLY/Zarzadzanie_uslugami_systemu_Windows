using System.Collections.Generic;
using System.ServiceProcess;

namespace MSService {
    class MSService : IMSService {

        public string GetServiceName(string service) {

            ServiceController s = new ServiceController(service);

            return s.ServiceName.ToString();
        }

        public string GetServiceStartType(string service) {

            ServiceController s = new ServiceController(service);

            return s.StartType.ToString();
        }

        public string GetServiceStatus(string service) {

            ServiceController s = new ServiceController(service);

            return s.Status.ToString();
        }

        public string GetServiceType(string service) {

            ServiceController s = new ServiceController(service);

            return s.ServiceType.ToString();
        }

        public List<string> ListAllServices() {

            ServiceController[] allServices = ServiceController.GetServices();
            List<string> servicesName = new List<string>();

            foreach (ServiceController service in allServices) {

                servicesName.Add(service.DisplayName);
            }

            return servicesName;
        }

        public void StartService(string displayName) {

            ServiceController service = new ServiceController(displayName);
            service.Start();
        }

        public void StopService(string displayName) {

            ServiceController service = new ServiceController(displayName);
            service.Stop();
        }
    }
}
