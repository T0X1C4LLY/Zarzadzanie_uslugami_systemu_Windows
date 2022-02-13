using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MSService {

    public class MSServiceMain : ServiceBase {

        public ServiceHost serviceHost = null;
        public MSServiceMain() {

        }

        public static void Main() {

            ServiceBase.Run(new MSServiceMain());
        }

        public static void WriteStartLog(string displayName) {

            LogWriter.StartLog(displayName);
        }

        public static void WriteStopLog(string displayName) {

            LogWriter.StopLog(displayName);
        }

        protected override void OnStart(string[] args) {

            LogWriter.createLogIfNotExist();

            if (serviceHost != null) {

                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(MSService));
            serviceHost.Open();
        }

        protected override void OnStop() {

            if (serviceHost != null) {

                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
