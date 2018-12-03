namespace SwissTransportApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.grbChooseAction = new System.Windows.Forms.GroupBox();
            this.lblSwitchAction = new System.Windows.Forms.Label();
            this.rdbSearchDeparts = new System.Windows.Forms.RadioButton();
            this.rdbSearchConnections = new System.Windows.Forms.RadioButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlTabSearchConnections = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchConnections = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSelectStartStation = new System.Windows.Forms.Panel();
            this.lsbSelectStartStation = new System.Windows.Forms.ListBox();
            this.txbSelectStartStation = new System.Windows.Forms.TextBox();
            this.lblSelectStartStation = new System.Windows.Forms.Label();
            this.pnlSelectEndStation = new System.Windows.Forms.Panel();
            this.lsbSelectEndStation = new System.Windows.Forms.ListBox();
            this.txbSelectEndStation = new System.Windows.Forms.TextBox();
            this.lblSelectEndStation = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.dtpDepartOrArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.grbDepartOrArrival = new System.Windows.Forms.GroupBox();
            this.rdbArrival = new System.Windows.Forms.RadioButton();
            this.rdbDepart = new System.Windows.Forms.RadioButton();
            this.dtpDepartOrArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.tblOutput = new System.Windows.Forms.DataGridView();
            this.clmDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.grbChooseAction.SuspendLayout();
            this.pnlTabSearchConnections.SuspendLayout();
            this.pnlSearchConnections.SuspendLayout();
            this.pnlSelectStartStation.SuspendLayout();
            this.pnlSelectEndStation.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.grbDepartOrArrival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.grbChooseAction);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(659, 49);
            this.pnlTop.TabIndex = 0;
            // 
            // grbChooseAction
            // 
            this.grbChooseAction.Controls.Add(this.lblSwitchAction);
            this.grbChooseAction.Controls.Add(this.rdbSearchDeparts);
            this.grbChooseAction.Controls.Add(this.rdbSearchConnections);
            this.grbChooseAction.Location = new System.Drawing.Point(13, 12);
            this.grbChooseAction.Name = "grbChooseAction";
            this.grbChooseAction.Size = new System.Drawing.Size(628, 31);
            this.grbChooseAction.TabIndex = 0;
            this.grbChooseAction.TabStop = false;
            this.grbChooseAction.Text = "Ich möchte:";
            // 
            // lblSwitchAction
            // 
            this.lblSwitchAction.AutoSize = true;
            this.lblSwitchAction.Location = new System.Drawing.Point(330, 10);
            this.lblSwitchAction.Name = "lblSwitchAction";
            this.lblSwitchAction.Size = new System.Drawing.Size(79, 13);
            this.lblSwitchAction.TabIndex = 2;
            this.lblSwitchAction.Text = "(Wechseln: F2)";
            // 
            // rdbSearchDeparts
            // 
            this.rdbSearchDeparts.AutoSize = true;
            this.rdbSearchDeparts.Location = new System.Drawing.Point(215, 8);
            this.rdbSearchDeparts.Name = "rdbSearchDeparts";
            this.rdbSearchDeparts.Size = new System.Drawing.Size(109, 17);
            this.rdbSearchDeparts.TabIndex = 1;
            this.rdbSearchDeparts.Text = "Abfahrten suchen";
            this.rdbSearchDeparts.UseVisualStyleBackColor = true;
            // 
            // rdbSearchConnections
            // 
            this.rdbSearchConnections.AutoSize = true;
            this.rdbSearchConnections.Checked = true;
            this.rdbSearchConnections.Location = new System.Drawing.Point(74, 8);
            this.rdbSearchConnections.Name = "rdbSearchConnections";
            this.rdbSearchConnections.Size = new System.Drawing.Size(129, 17);
            this.rdbSearchConnections.TabIndex = 0;
            this.rdbSearchConnections.TabStop = true;
            this.rdbSearchConnections.Text = "Verbindungen suchen";
            this.rdbSearchConnections.UseVisualStyleBackColor = true;
            this.rdbSearchConnections.CheckedChanged += new System.EventHandler(this.grbChooseAction_CheckedChanged);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 509);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(659, 52);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlTabSearchConnections
            // 
            this.pnlTabSearchConnections.AutoScroll = true;
            this.pnlTabSearchConnections.AutoSize = true;
            this.pnlTabSearchConnections.Controls.Add(this.pnlSearchConnections);
            this.pnlTabSearchConnections.Controls.Add(this.tblOutput);
            this.pnlTabSearchConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabSearchConnections.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTabSearchConnections.Location = new System.Drawing.Point(0, 49);
            this.pnlTabSearchConnections.Name = "pnlTabSearchConnections";
            this.pnlTabSearchConnections.Size = new System.Drawing.Size(659, 460);
            this.pnlTabSearchConnections.TabIndex = 2;
            // 
            // pnlSearchConnections
            // 
            this.pnlSearchConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchConnections.AutoSize = true;
            this.pnlSearchConnections.Controls.Add(this.pnlSelectStartStation);
            this.pnlSearchConnections.Controls.Add(this.pnlSelectEndStation);
            this.pnlSearchConnections.Controls.Add(this.pnlOptions);
            this.pnlSearchConnections.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchConnections.Name = "pnlSearchConnections";
            this.pnlSearchConnections.Size = new System.Drawing.Size(648, 151);
            this.pnlSearchConnections.TabIndex = 1;
            // 
            // pnlSelectStartStation
            // 
            this.pnlSelectStartStation.Controls.Add(this.lsbSelectStartStation);
            this.pnlSelectStartStation.Controls.Add(this.txbSelectStartStation);
            this.pnlSelectStartStation.Controls.Add(this.lblSelectStartStation);
            this.pnlSelectStartStation.Location = new System.Drawing.Point(3, 3);
            this.pnlSelectStartStation.Name = "pnlSelectStartStation";
            this.pnlSelectStartStation.Size = new System.Drawing.Size(210, 145);
            this.pnlSelectStartStation.TabIndex = 0;
            // 
            // lsbSelectStartStation
            // 
            this.lsbSelectStartStation.Enabled = false;
            this.lsbSelectStartStation.FormattingEnabled = true;
            this.lsbSelectStartStation.Location = new System.Drawing.Point(3, 42);
            this.lsbSelectStartStation.Name = "lsbSelectStartStation";
            this.lsbSelectStartStation.Size = new System.Drawing.Size(200, 95);
            this.lsbSelectStartStation.TabIndex = 2;
            this.lsbSelectStartStation.SelectedValueChanged += new System.EventHandler(this.lsbSelectStartStation_SelectedIndexChanged);
            this.lsbSelectStartStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbSelectStartStation_KeyDown);
            // 
            // txbSelectStartStation
            // 
            this.txbSelectStartStation.Location = new System.Drawing.Point(3, 16);
            this.txbSelectStartStation.Name = "txbSelectStartStation";
            this.txbSelectStartStation.Size = new System.Drawing.Size(200, 20);
            this.txbSelectStartStation.TabIndex = 1;
            this.txbSelectStartStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSelectStartStation_KeyDown);
            // 
            // lblSelectStartStation
            // 
            this.lblSelectStartStation.AutoSize = true;
            this.lblSelectStartStation.Location = new System.Drawing.Point(3, 0);
            this.lblSelectStartStation.Name = "lblSelectStartStation";
            this.lblSelectStartStation.Size = new System.Drawing.Size(189, 13);
            this.lblSelectStartStation.TabIndex = 0;
            this.lblSelectStartStation.Text = "Startstation auswählen (Autocomp: F1)";
            // 
            // pnlSelectEndStation
            // 
            this.pnlSelectEndStation.Controls.Add(this.lsbSelectEndStation);
            this.pnlSelectEndStation.Controls.Add(this.txbSelectEndStation);
            this.pnlSelectEndStation.Controls.Add(this.lblSelectEndStation);
            this.pnlSelectEndStation.Location = new System.Drawing.Point(219, 3);
            this.pnlSelectEndStation.Name = "pnlSelectEndStation";
            this.pnlSelectEndStation.Size = new System.Drawing.Size(210, 145);
            this.pnlSelectEndStation.TabIndex = 1;
            // 
            // lsbSelectEndStation
            // 
            this.lsbSelectEndStation.Enabled = false;
            this.lsbSelectEndStation.FormattingEnabled = true;
            this.lsbSelectEndStation.Location = new System.Drawing.Point(3, 42);
            this.lsbSelectEndStation.Name = "lsbSelectEndStation";
            this.lsbSelectEndStation.Size = new System.Drawing.Size(200, 95);
            this.lsbSelectEndStation.TabIndex = 2;
            this.lsbSelectEndStation.SelectedValueChanged += new System.EventHandler(this.lsbSelectEndStation_SelectedIndexChanged);
            this.lsbSelectEndStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbSelectEndStation_KeyDown);
            // 
            // txbSelectEndStation
            // 
            this.txbSelectEndStation.Location = new System.Drawing.Point(3, 16);
            this.txbSelectEndStation.Name = "txbSelectEndStation";
            this.txbSelectEndStation.Size = new System.Drawing.Size(200, 20);
            this.txbSelectEndStation.TabIndex = 1;
            this.txbSelectEndStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbSelectEndStation_KeyDown);
            // 
            // lblSelectEndStation
            // 
            this.lblSelectEndStation.AutoSize = true;
            this.lblSelectEndStation.Location = new System.Drawing.Point(3, 0);
            this.lblSelectEndStation.Name = "lblSelectEndStation";
            this.lblSelectEndStation.Size = new System.Drawing.Size(184, 13);
            this.lblSelectEndStation.TabIndex = 0;
            this.lblSelectEndStation.Text = "Zielstation auswählen (Autocomp: F1)";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.dtpDepartOrArrivalTime);
            this.pnlOptions.Controls.Add(this.grbDepartOrArrival);
            this.pnlOptions.Controls.Add(this.dtpDepartOrArrivalDate);
            this.pnlOptions.Controls.Add(this.btnSearchConnections);
            this.pnlOptions.Location = new System.Drawing.Point(435, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(210, 145);
            this.pnlOptions.TabIndex = 2;
            // 
            // dtpDepartOrArrivalTime
            // 
            this.dtpDepartOrArrivalTime.CustomFormat = "HH:mm";
            this.dtpDepartOrArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartOrArrivalTime.Location = new System.Drawing.Point(133, 88);
            this.dtpDepartOrArrivalTime.Name = "dtpDepartOrArrivalTime";
            this.dtpDepartOrArrivalTime.ShowUpDown = true;
            this.dtpDepartOrArrivalTime.Size = new System.Drawing.Size(70, 20);
            this.dtpDepartOrArrivalTime.TabIndex = 2;
            // 
            // grbDepartOrArrival
            // 
            this.grbDepartOrArrival.Controls.Add(this.rdbArrival);
            this.grbDepartOrArrival.Controls.Add(this.rdbDepart);
            this.grbDepartOrArrival.Location = new System.Drawing.Point(3, 42);
            this.grbDepartOrArrival.Name = "grbDepartOrArrival";
            this.grbDepartOrArrival.Size = new System.Drawing.Size(200, 40);
            this.grbDepartOrArrival.TabIndex = 0;
            this.grbDepartOrArrival.TabStop = false;
            // 
            // rdbArrival
            // 
            this.rdbArrival.AutoSize = true;
            this.rdbArrival.Location = new System.Drawing.Point(109, 17);
            this.rdbArrival.Name = "rdbArrival";
            this.rdbArrival.Size = new System.Drawing.Size(82, 17);
            this.rdbArrival.TabIndex = 1;
            this.rdbArrival.Text = "Ankunft um:";
            this.rdbArrival.UseVisualStyleBackColor = true;
            // 
            // rdbDepart
            // 
            this.rdbDepart.AutoSize = true;
            this.rdbDepart.Checked = true;
            this.rdbDepart.Location = new System.Drawing.Point(7, 17);
            this.rdbDepart.Name = "rdbDepart";
            this.rdbDepart.Size = new System.Drawing.Size(79, 17);
            this.rdbDepart.TabIndex = 0;
            this.rdbDepart.TabStop = true;
            this.rdbDepart.Text = "Abfahrt um:";
            this.rdbDepart.UseVisualStyleBackColor = true;
            // 
            // dtpDepartOrArrivalDate
            // 
            this.dtpDepartOrArrivalDate.CustomFormat = "";
            this.dtpDepartOrArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartOrArrivalDate.Location = new System.Drawing.Point(3, 88);
            this.dtpDepartOrArrivalDate.Name = "dtpDepartOrArrivalDate";
            this.dtpDepartOrArrivalDate.Size = new System.Drawing.Size(124, 20);
            this.dtpDepartOrArrivalDate.TabIndex = 1;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(3, 114);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(200, 23);
            this.btnSearchConnections.TabIndex = 3;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // tblOutput
            // 
            this.tblOutput.AllowUserToAddRows = false;
            this.tblOutput.AllowUserToDeleteRows = false;
            this.tblOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDeparture,
            this.clmDuration,
            this.clmArrival});
            this.tblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOutput.Location = new System.Drawing.Point(3, 160);
            this.tblOutput.Name = "tblOutput";
            this.tblOutput.ReadOnly = true;
            this.tblOutput.Size = new System.Drawing.Size(648, 290);
            this.tblOutput.TabIndex = 3;
            // 
            // clmDeparture
            // 
            this.clmDeparture.HeaderText = "Abfahrt";
            this.clmDeparture.Name = "clmDeparture";
            this.clmDeparture.ReadOnly = true;
            // 
            // clmDuration
            // 
            this.clmDuration.HeaderText = "Dauer";
            this.clmDuration.Name = "clmDuration";
            this.clmDuration.ReadOnly = true;
            // 
            // clmArrival
            // 
            this.clmArrival.HeaderText = "Ankunft";
            this.clmArrival.Name = "clmArrival";
            this.clmArrival.ReadOnly = true;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.btnSearchConnections;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 561);
            this.Controls.Add(this.pnlTabSearchConnections);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(675, 600);
            this.MinimumSize = new System.Drawing.Size(675, 600);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verbindung suchen - ÖV-Applikation";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.pnlTop.ResumeLayout(false);
            this.grbChooseAction.ResumeLayout(false);
            this.grbChooseAction.PerformLayout();
            this.pnlTabSearchConnections.ResumeLayout(false);
            this.pnlTabSearchConnections.PerformLayout();
            this.pnlSearchConnections.ResumeLayout(false);
            this.pnlSelectStartStation.ResumeLayout(false);
            this.pnlSelectStartStation.PerformLayout();
            this.pnlSelectEndStation.ResumeLayout(false);
            this.pnlSelectEndStation.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            this.grbDepartOrArrival.ResumeLayout(false);
            this.grbDepartOrArrival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.FlowLayoutPanel pnlTabSearchConnections;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchConnections;
        private System.Windows.Forms.Panel pnlSelectStartStation;
        private System.Windows.Forms.ListBox lsbSelectStartStation;
        private System.Windows.Forms.TextBox txbSelectStartStation;
        private System.Windows.Forms.Label lblSelectStartStation;
        private System.Windows.Forms.Panel pnlSelectEndStation;
        private System.Windows.Forms.ListBox lsbSelectEndStation;
        private System.Windows.Forms.TextBox txbSelectEndStation;
        private System.Windows.Forms.Label lblSelectEndStation;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.DataGridView tblOutput;
        private System.Windows.Forms.DateTimePicker dtpDepartOrArrivalDate;
        private System.Windows.Forms.GroupBox grbDepartOrArrival;
        private System.Windows.Forms.RadioButton rdbArrival;
        private System.Windows.Forms.RadioButton rdbDepart;
        private System.Windows.Forms.DateTimePicker dtpDepartOrArrivalTime;
        private System.Windows.Forms.GroupBox grbChooseAction;
        private System.Windows.Forms.RadioButton rdbSearchConnections;
        private System.Windows.Forms.RadioButton rdbSearchDeparts;
        private System.Windows.Forms.Label lblSwitchAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArrival;
    }
}

