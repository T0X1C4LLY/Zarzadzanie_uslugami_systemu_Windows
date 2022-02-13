using System;
using System.ServiceProcess;
using System.Windows.Forms;
using ManagingServicesLibrary;
using System.Diagnostics;
using System.Windows.Threading;
using MSService;
using System.Collections.Generic;

namespace ManagingServicesApp {    

    public partial class Form1 : Form {

        ServiceControllerStatus previusStatus;
        List<string> services;
        string actualService;
        DispatcherTimer dt;
        MSServiceClient client = new MSServiceClient();

        public Form1() {

            InitializeComponent();
            CheckIfMainServiceIsInstalled();
            CheckIfMainServiceIsRunning();
            GetAllServices();

            actualService = "MainService";

            dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dt.Tick += Tick;
            dt.Start();
        }

        private void CheckIfMainServiceIsInstalled() {

            if (ManagingServicesClass.IsMainServiceNotInstalled()) {

                string title = "WARNING!";
                string warning = "MainService wasn't detected on Your computer, please install it !";

                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(warning, title, button);
            }
        }

        private void CheckIfMainServiceIsRunning() {

            if (ManagingServicesClass.IsMainServiceNotRunning()) {

                string title = "WARNING!";
                string warning = "MainService is NOT running! \n\nDo You want to start it now?";

                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(warning, title, button);

                if (result == DialogResult.Yes) {

                    ManagingServicesClass.StartMainService();                    
                } 
            }
        }

        private void Tick(object sender, EventArgs e) {
            
            if(actualService != null) {

                ServiceController s = new ServiceController(actualService);

                s.Refresh();
                ServiceControllerStatus status = s.Status;

                if (status != previusStatus) {

                    StatusTextBox.Text = status.ToString();
                    ButtonController();
                    previusStatus = status;
                }
            }
            DisableButtonsIfMainService();
        }

        private void GetAllServices() {
            
            services = client.ListAllServices();
            serviceList.Items.Clear();
            
            foreach (string sc in services) {

                serviceList.Items.Add(sc);
            }     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
            if (serviceList.SelectedItems.Count > 0) {

                ServiceController sc = new ServiceController(actualService);

                actualService = serviceList.SelectedItems[0].ToString();

                displayNameTextBox.Text = actualService;                
                serviceNameTextBox.Text = client.GetServiceName(actualService);
                RefreshStatus();
                ServiceTypeTextBox.Text = client.GetServiceType(actualService);
                DependentServicesListBox.Items.Clear();

                foreach (ServiceController s in sc.DependentServices) {

                    DependentServicesListBox.Items.Add(s.DisplayName);
                }

                StartTypeTextBox.Text = client.GetServiceStartType(actualService);
                ButtonController();
                DisableButtonsIfMainService();
            }
        }

        private void DisableButtonsIfMainService() {

            if (actualService != null) {
                if (actualService.Equals("ServicesManagerService")) {

                    StartButton.Enabled = false;
                    StopButton.Enabled = false;
                }
            }            
        }

        private void StartButton_Click(object sender, EventArgs e) {

            client.StartService(actualService);
            MSServiceMain.WriteStartLog(actualService);
            AddStartEntryInActionWatcher(actualService);
            ButtonController();
            RefreshStatus();
            RefreshLogWriterListBox();
        }

        private void StopButton_Click(object sender, EventArgs e) {

            client.StopService(actualService);
            MSServiceMain.WriteStopLog(actualService);
            AddStopEntryInActionWatcher(actualService);
            ButtonController();
            RefreshStatus();
            RefreshLogWriterListBox();
        }

        private void ButtonController() {

            if (ManagingServicesClass.isServiceRunning(actualService)) {

                StartButton.Enabled = false;
                StopButton.Enabled = true;
            } else {

                StartButton.Enabled = true;
                StopButton.Enabled = false;
            }
        }

        private void RefreshStatus() {

            StatusTextBox.Text = client.GetServiceStatus(actualService);
        }

        private void AddStartEntryInActionWatcher(string displayName) {

            ActionWatcherListBox.Items.Add(DateTime.Now + ": You STARTED: " + displayName);
        }

        private void AddStopEntryInActionWatcher(string displayName) {

            ActionWatcherListBox.Items.Add(DateTime.Now + ": You STOPPED: " + displayName);
        }

        private void RefreshLogWriterListBox() {

            LogWriterListBox.Items.Clear();

            EventLog entries = ManagingServicesClass.GetAllLogs();

            foreach (EventLogEntry entry in entries.Entries) {

                LogWriterListBox.Items.Add(entry.Message);
            }
        }

        private void ClearLOgWriterButton_Click(object sender, EventArgs e) {

            ManagingServicesClass.ClearLogWriter();
            RefreshLogWriterListBox();
        }

        private void ClearActionsWatcherButton_Click(object sender, EventArgs e) {

            ActionWatcherListBox.Items.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e) {

            RefreshLogWriterListBox();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {

            GetAllServices();
        }
    }
}