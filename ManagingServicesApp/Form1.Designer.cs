
namespace ManagingServicesApp {
    partial class Form1 {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            this.ShowButton = new System.Windows.Forms.Button();
            this.serviceList = new System.Windows.Forms.ListBox();
            this.ServiceListLabel = new System.Windows.Forms.Label();
            this.LogWriterListBox = new System.Windows.Forms.ListBox();
            this.LogWriterLabel = new System.Windows.Forms.Label();
            this.ActionWatcherListBox = new System.Windows.Forms.ListBox();
            this.ArcionsWatcherLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ServisInfoLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.displayNameTextBox = new System.Windows.Forms.TextBox();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.ServiceTypeLabel = new System.Windows.Forms.Label();
            this.ServiceTypeTextBox = new System.Windows.Forms.TextBox();
            this.DependentServicesLabel = new System.Windows.Forms.Label();
            this.DependentServicesListBox = new System.Windows.Forms.ListBox();
            this.StartTypeLabel = new System.Windows.Forms.Label();
            this.StartTypeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearLOgWriterButton = new System.Windows.Forms.Button();
            this.ClearActionsWatcherButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(48, 814);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(128, 57);
            this.ShowButton.TabIndex = 27;
            this.ShowButton.Text = "SHOW";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // serviceList
            // 
            this.serviceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.serviceList.FormattingEnabled = true;
            this.serviceList.ItemHeight = 16;
            this.serviceList.Location = new System.Drawing.Point(12, 48);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(486, 324);
            this.serviceList.Sorted = true;
            this.serviceList.TabIndex = 3;
            this.serviceList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ServiceListLabel
            // 
            this.ServiceListLabel.AutoSize = true;
            this.ServiceListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServiceListLabel.Location = new System.Drawing.Point(128, 14);
            this.ServiceListLabel.Name = "ServiceListLabel";
            this.ServiceListLabel.Size = new System.Drawing.Size(234, 31);
            this.ServiceListLabel.TabIndex = 4;
            this.ServiceListLabel.Text = "Service Name List";
            // 
            // LogWriterListBox
            // 
            this.LogWriterListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogWriterListBox.FormattingEnabled = true;
            this.LogWriterListBox.ItemHeight = 16;
            this.LogWriterListBox.Location = new System.Drawing.Point(12, 484);
            this.LogWriterListBox.Name = "LogWriterListBox";
            this.LogWriterListBox.Size = new System.Drawing.Size(486, 324);
            this.LogWriterListBox.TabIndex = 20;
            // 
            // LogWriterLabel
            // 
            this.LogWriterLabel.AutoSize = true;
            this.LogWriterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogWriterLabel.Location = new System.Drawing.Point(176, 450);
            this.LogWriterLabel.Name = "LogWriterLabel";
            this.LogWriterLabel.Size = new System.Drawing.Size(138, 31);
            this.LogWriterLabel.TabIndex = 21;
            this.LogWriterLabel.Text = "Log Writer";
            // 
            // ActionWatcherListBox
            // 
            this.ActionWatcherListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActionWatcherListBox.FormattingEnabled = true;
            this.ActionWatcherListBox.ItemHeight = 16;
            this.ActionWatcherListBox.Location = new System.Drawing.Point(519, 484);
            this.ActionWatcherListBox.Name = "ActionWatcherListBox";
            this.ActionWatcherListBox.Size = new System.Drawing.Size(486, 324);
            this.ActionWatcherListBox.TabIndex = 22;
            // 
            // ArcionsWatcherLabel
            // 
            this.ArcionsWatcherLabel.AutoSize = true;
            this.ArcionsWatcherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ArcionsWatcherLabel.Location = new System.Drawing.Point(635, 450);
            this.ArcionsWatcherLabel.Name = "ArcionsWatcherLabel";
            this.ArcionsWatcherLabel.Size = new System.Drawing.Size(212, 31);
            this.ArcionsWatcherLabel.TabIndex = 23;
            this.ArcionsWatcherLabel.Text = "Actions Watcher";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(0, 293);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(128, 57);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(358, 293);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(128, 57);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ServisInfoLabel
            // 
            this.ServisInfoLabel.AutoSize = true;
            this.ServisInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ServisInfoLabel.Location = new System.Drawing.Point(170, 0);
            this.ServisInfoLabel.Name = "ServisInfoLabel";
            this.ServisInfoLabel.Size = new System.Drawing.Size(158, 31);
            this.ServisInfoLabel.TabIndex = 5;
            this.ServisInfoLabel.Text = "Service Info";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.displayNameLabel.Location = new System.Drawing.Point(2, 42);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(87, 15);
            this.displayNameLabel.TabIndex = 6;
            this.displayNameLabel.Text = "Display Name:";
            // 
            // displayNameTextBox
            // 
            this.displayNameTextBox.Enabled = false;
            this.displayNameTextBox.Location = new System.Drawing.Point(128, 41);
            this.displayNameTextBox.Name = "displayNameTextBox";
            this.displayNameTextBox.Size = new System.Drawing.Size(358, 20);
            this.displayNameTextBox.TabIndex = 7;
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.serviceNameLabel.Location = new System.Drawing.Point(2, 68);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(87, 15);
            this.serviceNameLabel.TabIndex = 8;
            this.serviceNameLabel.Text = "Service Name:";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Enabled = false;
            this.serviceNameTextBox.Location = new System.Drawing.Point(128, 67);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(358, 20);
            this.serviceNameTextBox.TabIndex = 9;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.StatusLabel.Location = new System.Drawing.Point(2, 92);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 15);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Enabled = false;
            this.StatusTextBox.Location = new System.Drawing.Point(128, 91);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(358, 20);
            this.StatusTextBox.TabIndex = 11;
            // 
            // ServiceTypeLabel
            // 
            this.ServiceTypeLabel.AutoSize = true;
            this.ServiceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.ServiceTypeLabel.Location = new System.Drawing.Point(2, 118);
            this.ServiceTypeLabel.Name = "ServiceTypeLabel";
            this.ServiceTypeLabel.Size = new System.Drawing.Size(79, 15);
            this.ServiceTypeLabel.TabIndex = 12;
            this.ServiceTypeLabel.Text = "Service Type:";
            // 
            // ServiceTypeTextBox
            // 
            this.ServiceTypeTextBox.Enabled = false;
            this.ServiceTypeTextBox.Location = new System.Drawing.Point(128, 117);
            this.ServiceTypeTextBox.Name = "ServiceTypeTextBox";
            this.ServiceTypeTextBox.Size = new System.Drawing.Size(358, 20);
            this.ServiceTypeTextBox.TabIndex = 13;
            // 
            // DependentServicesLabel
            // 
            this.DependentServicesLabel.AutoSize = true;
            this.DependentServicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.DependentServicesLabel.Location = new System.Drawing.Point(2, 144);
            this.DependentServicesLabel.Name = "DependentServicesLabel";
            this.DependentServicesLabel.Size = new System.Drawing.Size(120, 15);
            this.DependentServicesLabel.TabIndex = 14;
            this.DependentServicesLabel.Text = "Dependent Services:";
            // 
            // DependentServicesListBox
            // 
            this.DependentServicesListBox.FormattingEnabled = true;
            this.DependentServicesListBox.Location = new System.Drawing.Point(128, 144);
            this.DependentServicesListBox.Name = "DependentServicesListBox";
            this.DependentServicesListBox.Size = new System.Drawing.Size(358, 69);
            this.DependentServicesListBox.Sorted = true;
            this.DependentServicesListBox.TabIndex = 15;
            // 
            // StartTypeLabel
            // 
            this.StartTypeLabel.AutoSize = true;
            this.StartTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.StartTypeLabel.Location = new System.Drawing.Point(2, 221);
            this.StartTypeLabel.Name = "StartTypeLabel";
            this.StartTypeLabel.Size = new System.Drawing.Size(64, 15);
            this.StartTypeLabel.TabIndex = 16;
            this.StartTypeLabel.Text = "Start Type:";
            // 
            // StartTypeTextBox
            // 
            this.StartTypeTextBox.Enabled = false;
            this.StartTypeTextBox.Location = new System.Drawing.Point(128, 220);
            this.StartTypeTextBox.Name = "StartTypeTextBox";
            this.StartTypeTextBox.Size = new System.Drawing.Size(358, 20);
            this.StartTypeTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartTypeTextBox);
            this.groupBox1.Controls.Add(this.StartTypeLabel);
            this.groupBox1.Controls.Add(this.DependentServicesListBox);
            this.groupBox1.Controls.Add(this.DependentServicesLabel);
            this.groupBox1.Controls.Add(this.ServiceTypeTextBox);
            this.groupBox1.Controls.Add(this.ServiceTypeLabel);
            this.groupBox1.Controls.Add(this.StatusTextBox);
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Controls.Add(this.serviceNameTextBox);
            this.groupBox1.Controls.Add(this.serviceNameLabel);
            this.groupBox1.Controls.Add(this.displayNameTextBox);
            this.groupBox1.Controls.Add(this.displayNameLabel);
            this.groupBox1.Controls.Add(this.ServisInfoLabel);
            this.groupBox1.Controls.Add(this.StopButton);
            this.groupBox1.Controls.Add(this.StartButton);
            this.groupBox1.Location = new System.Drawing.Point(519, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 358);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // ClearLOgWriterButton
            // 
            this.ClearLOgWriterButton.Location = new System.Drawing.Point(321, 814);
            this.ClearLOgWriterButton.Name = "ClearLOgWriterButton";
            this.ClearLOgWriterButton.Size = new System.Drawing.Size(128, 57);
            this.ClearLOgWriterButton.TabIndex = 25;
            this.ClearLOgWriterButton.Text = "CLEAR";
            this.ClearLOgWriterButton.UseVisualStyleBackColor = true;
            this.ClearLOgWriterButton.Click += new System.EventHandler(this.ClearLOgWriterButton_Click);
            // 
            // ClearActionsWatcherButton
            // 
            this.ClearActionsWatcherButton.Location = new System.Drawing.Point(695, 814);
            this.ClearActionsWatcherButton.Name = "ClearActionsWatcherButton";
            this.ClearActionsWatcherButton.Size = new System.Drawing.Size(128, 57);
            this.ClearActionsWatcherButton.TabIndex = 26;
            this.ClearActionsWatcherButton.Text = "CLEAR";
            this.ClearActionsWatcherButton.UseVisualStyleBackColor = true;
            this.ClearActionsWatcherButton.Click += new System.EventHandler(this.ClearActionsWatcherButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(186, 378);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(128, 57);
            this.RefreshButton.TabIndex = 28;
            this.RefreshButton.Text = "REFRESH";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 877);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ClearActionsWatcherButton);
            this.Controls.Add(this.ClearLOgWriterButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ArcionsWatcherLabel);
            this.Controls.Add(this.ActionWatcherListBox);
            this.Controls.Add(this.LogWriterLabel);
            this.Controls.Add(this.LogWriterListBox);
            this.Controls.Add(this.ServiceListLabel);
            this.Controls.Add(this.serviceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Services Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.ListBox serviceList;
        private System.Windows.Forms.Label ServiceListLabel;
        private System.Windows.Forms.ListBox LogWriterListBox;
        private System.Windows.Forms.Label LogWriterLabel;
        private System.Windows.Forms.ListBox ActionWatcherListBox;
        private System.Windows.Forms.Label ArcionsWatcherLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label ServisInfoLabel;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.TextBox displayNameTextBox;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.TextBox serviceNameTextBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label ServiceTypeLabel;
        private System.Windows.Forms.TextBox ServiceTypeTextBox;
        private System.Windows.Forms.Label DependentServicesLabel;
        private System.Windows.Forms.ListBox DependentServicesListBox;
        private System.Windows.Forms.Label StartTypeLabel;
        private System.Windows.Forms.TextBox StartTypeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearLOgWriterButton;
        private System.Windows.Forms.Button ClearActionsWatcherButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}

