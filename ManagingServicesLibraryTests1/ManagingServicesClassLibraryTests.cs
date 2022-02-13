using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace ManagingServicesLibrary.Tests {

    [TestClass()]
    public class ManagingServicesClassLibraryTests {

        /*
        [TestMethod()]
        public void GetFocusedServiceAreEqualTest() {

            ServiceController service = new ServiceController("MainService");
            string serviceName = "ServicesManagerService";

            ServiceController takenService = ManagingServicesClass.GetFocusedService(serviceName);

            Assert.AreEqual(service.DisplayName, takenService.DisplayName);
            Assert.AreEqual(service.ServiceName, takenService.ServiceName);
        }

        [TestMethod()]
        public void GetFocusedServiceAreEqualTest2() {

            ServiceController[] allServices = ServiceController.GetServices();
            string serviceName = "THIS SERVICE DO NOT EXIST";

            ServiceController takenService = ManagingServicesClass.GetFocusedService(serviceName);

            Assert.AreEqual(allServices[0].DisplayName, takenService.DisplayName);
            Assert.AreEqual(allServices[0].ServiceName, takenService.ServiceName);
        }

        [TestMethod()]
        public void GetFocusedServiceAreNotEqualTest() {

            ServiceController service = new ServiceController("MainService");
            string serviceName = "THIS SERVICE DO NOT EXIST";

            ServiceController takenService = ManagingServicesClass.GetFocusedService(serviceName);

            Assert.AreNotEqual(service.DisplayName, takenService.DisplayName);
            Assert.AreNotEqual(service.ServiceName, takenService.ServiceName);
        }*/        

        [TestMethod()]
        public void IsMainServiceNotInstalledAreEqualTest() {

            ServiceController service = new ServiceController("MainService");
            bool myValue = (service == null);

            bool returnedValue = ManagingServicesClass.IsMainServiceNotInstalled();

            Assert.AreEqual(myValue, returnedValue);
        }

        [TestMethod()]
        public void IsMainServiceNotInstalledAreNotEqualTest() {

            ServiceController service = new ServiceController("MainService");
            bool myValue = !(service == null);

            bool returnedValue = ManagingServicesClass.IsMainServiceNotInstalled();

            Assert.AreNotEqual(myValue, returnedValue);
        }

        [TestMethod()]
        public void IsMainServiceNotRunningAreEqualTest() {

            ServiceController service = new ServiceController("MainService");
            bool myValue;

            myValue = !(service.Status.ToString().Equals("Running"));

            bool returnedValue = ManagingServicesClass.IsMainServiceNotRunning();

            Assert.AreEqual(myValue, returnedValue);
        }

        [TestMethod()]
        public void IsMainServiceNotRunningAreNotEqualTest() {

            ServiceController service = new ServiceController("MainService");
            bool myValue;

            myValue = (service.Status.ToString().Equals("Running"));

            bool returnedValue = ManagingServicesClass.IsMainServiceNotRunning();

            Assert.AreNotEqual(myValue, returnedValue);
        }

        [TestMethod()]
        public void StartMainServiceAreEqualTest() {

            ServiceController service = new ServiceController("MainService");
            ManagingServicesClass.StartMainService();

            Assert.AreEqual(service.Status.ToString(), "Running");
        }

        [TestMethod()]
        public void StartMainServiceAreNotEqualTest() {

            ServiceController service = new ServiceController("MainService");
            ManagingServicesClass.StartMainService();

            Assert.AreNotEqual(service.Status.ToString(), "Stopped");
        }

        /*
        [TestMethod()]
        public void StartServiceExceptionTest() {

            Assert.ThrowsException<ArgumentException>(() => ManagingServicesClass.StartService(null));
        }

        [TestMethod()]
        public void StopServiceExceptionTest() {

            Assert.ThrowsException<ArgumentException>(() => ManagingServicesClass.StopService(null));
        }

        [TestMethod()]
        public void ListAllServicesAreEqualTest() {

            ServiceController[] services = ServiceController.GetServices();

            ServiceController[] takenServices = ManagingServicesClass.listAllServices();

            Assert.AreEqual(services[0].DisplayName, takenServices[0].DisplayName);
            Assert.AreEqual(services[0].ServiceName, takenServices[0].ServiceName);
            Assert.AreEqual(services[1].DisplayName, takenServices[1].DisplayName);
            Assert.AreEqual(services[1].ServiceName, takenServices[1].ServiceName);
            Assert.AreEqual(services[5].DisplayName, takenServices[5].DisplayName);
            Assert.AreEqual(services[5].ServiceName, takenServices[5].ServiceName);
        }

        [TestMethod()]
        public void ListAllServicesAreNotEqualTest() {

            ServiceController[] services = ServiceController.GetServices();

            ServiceController[] takenServices = ManagingServicesClass.listAllServices();

            Assert.AreNotEqual(services[0].DisplayName, takenServices[1].DisplayName);
            Assert.AreNotEqual(services[0].ServiceName, takenServices[1].ServiceName);
            Assert.AreNotEqual(services[1].DisplayName, takenServices[2].DisplayName);
            Assert.AreNotEqual(services[1].ServiceName, takenServices[2].ServiceName);
            Assert.AreNotEqual(services[5].DisplayName, takenServices[9].DisplayName);
            Assert.AreNotEqual(services[5].ServiceName, takenServices[9].ServiceName);
        }*/

        [TestMethod()]
        public void GetAllLogsAreEqualTest() {

            const string LogName = "Managing Services Log Writer";
            const string LogSource = "Managing Services";
            EventLog myLog = new EventLog();
            myLog.Log = LogName;
            EventLog DemoLog = new EventLog(LogName);
            DemoLog.Source = LogSource;
            DemoLog.WriteEntry("TEST LOG", EventLogEntryType.Warning);


            EventLog takenLog = ManagingServicesClass.GetAllLogs();

            Assert.AreEqual(myLog.Entries[0].Message, takenLog.Entries[0].Message);
        }

        [TestMethod()]
        public void GetAllLogsAreNotEqualTest() {

            const string LogName = "Managing Services Log Writer";
            const string LogSource = "Managing Services";

            EventLog DemoLog = new EventLog(LogName);
            DemoLog.Source = LogSource;
            DemoLog.WriteEntry("TEST LOG", EventLogEntryType.Warning);

            EventLog myLog = new EventLog();
            myLog.Log = "Windows PowerShell";

            EventLog takenLog = ManagingServicesClass.GetAllLogs();

            Assert.AreNotEqual(myLog.Entries[0].Message, takenLog.Entries[0].Message);
        }

        [TestMethod()]
        public void ClearLogWriterAreNotEqualTest() {

            const string LogName = "Managing Services Log Writer";
            const string LogSource = "Managing Services";

            EventLog myLog = new EventLog();
            myLog.Log = LogName;

            EventLog DemoLog = new EventLog(LogName);
            DemoLog.Source = LogSource;
            DemoLog.WriteEntry("TEST LOG", EventLogEntryType.Warning);

            string lastEntry = "";
            string lastEntryAfterClear = "";

            foreach (EventLogEntry entry in myLog.Entries) {

                lastEntry = entry.Message;
            }

            ManagingServicesClass.ClearLogWriter();

            foreach (EventLogEntry entry in myLog.Entries) {

                lastEntryAfterClear = entry.Message;
            }

            Assert.AreNotEqual(lastEntry, lastEntryAfterClear);
        }

        [TestMethod()]
        public void isServiceRunningTrueTest() {

            ServiceController service = new ServiceController("MainService");

            Assert.AreEqual(service.Status.ToString().Equals("Running"), ManagingServicesClass.isServiceRunning("MainService"));
        }
    }
}