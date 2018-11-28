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
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.tblShowConnections = new System.Windows.Forms.DataGridView();
            this.clmDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTabSearchConnections.SuspendLayout();
            this.pnlSearchConnections.SuspendLayout();
            this.pnlSelectStartStation.SuspendLayout();
            this.pnlSelectEndStation.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblShowConnections)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(684, 49);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 509);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(684, 52);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlTabSearchConnections
            // 
            this.pnlTabSearchConnections.AutoScroll = true;
            this.pnlTabSearchConnections.AutoSize = true;
            this.pnlTabSearchConnections.Controls.Add(this.pnlSearchConnections);
            this.pnlTabSearchConnections.Controls.Add(this.tblShowConnections);
            this.pnlTabSearchConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabSearchConnections.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTabSearchConnections.Location = new System.Drawing.Point(0, 49);
            this.pnlTabSearchConnections.Name = "pnlTabSearchConnections";
            this.pnlTabSearchConnections.Size = new System.Drawing.Size(684, 460);
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
            this.lsbSelectStartStation.TabIndexChanged += new System.EventHandler(this.lsbSelectStartStation_SelectedIndexChanged);
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
            this.lblSelectStartStation.Size = new System.Drawing.Size(114, 13);
            this.lblSelectStartStation.TabIndex = 0;
            this.lblSelectStartStation.Text = "Startstation auswählen";
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
            this.lsbSelectEndStation.TabIndexChanged += new System.EventHandler(this.lsbSelectEndStation_SelectedIndexChanged);
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
            this.lblSelectEndStation.Size = new System.Drawing.Size(109, 13);
            this.lblSelectEndStation.TabIndex = 0;
            this.lblSelectEndStation.Text = "Zielstation auswählen";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnSearchConnections);
            this.pnlOptions.Location = new System.Drawing.Point(435, 3);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(210, 28);
            this.pnlOptions.TabIndex = 2;
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(3, 3);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(200, 23);
            this.btnSearchConnections.TabIndex = 0;
            this.btnSearchConnections.Text = "Verbindungen suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // tblShowConnections
            // 
            this.tblShowConnections.AllowUserToAddRows = false;
            this.tblShowConnections.AllowUserToDeleteRows = false;
            this.tblShowConnections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblShowConnections.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tblShowConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblShowConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDeparture,
            this.clmDuration,
            this.clmArrival});
            this.tblShowConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblShowConnections.Location = new System.Drawing.Point(3, 160);
            this.tblShowConnections.Name = "tblShowConnections";
            this.tblShowConnections.ReadOnly = true;
            this.tblShowConnections.Size = new System.Drawing.Size(648, 150);
            this.tblShowConnections.TabIndex = 3;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.pnlTabSearchConnections);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "MainWindow";
            this.Text = "Verbindung suchen - ÖV-Applikation";
            this.pnlTabSearchConnections.ResumeLayout(false);
            this.pnlTabSearchConnections.PerformLayout();
            this.pnlSearchConnections.ResumeLayout(false);
            this.pnlSelectStartStation.ResumeLayout(false);
            this.pnlSelectStartStation.PerformLayout();
            this.pnlSelectEndStation.ResumeLayout(false);
            this.pnlSelectEndStation.PerformLayout();
            this.pnlOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblShowConnections)).EndInit();
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
        private System.Windows.Forms.DataGridView tblShowConnections;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArrival;
    }
}

