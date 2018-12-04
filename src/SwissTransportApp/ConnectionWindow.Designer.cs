namespace SwissTransportApp
{
    partial class ConnectionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionWindow));
            this.lblFrom = new System.Windows.Forms.Label();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.txbDepart = new System.Windows.Forms.TextBox();
            this.lblDepartPlatform = new System.Windows.Forms.Label();
            this.txbDepartPlatform = new System.Windows.Forms.TextBox();
            this.txbArrivalPlatform = new System.Windows.Forms.TextBox();
            this.lblArrivalPlatform = new System.Windows.Forms.Label();
            this.txbArrival = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.txbProducts = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.txbDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnViewStartLocation = new System.Windows.Forms.Button();
            this.btnViewEndLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 35);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von:";
            // 
            // txbFrom
            // 
            this.txbFrom.Location = new System.Drawing.Point(142, 32);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.ReadOnly = true;
            this.txbFrom.Size = new System.Drawing.Size(200, 20);
            this.txbFrom.TabIndex = 2;
            this.txbFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(12, 61);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(61, 13);
            this.lblDepart.TabIndex = 2;
            this.lblDepart.Text = "Abfahrt um:";
            // 
            // txbDepart
            // 
            this.txbDepart.Location = new System.Drawing.Point(142, 58);
            this.txbDepart.Name = "txbDepart";
            this.txbDepart.ReadOnly = true;
            this.txbDepart.Size = new System.Drawing.Size(200, 20);
            this.txbDepart.TabIndex = 3;
            this.txbDepart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblDepartPlatform
            // 
            this.lblDepartPlatform.AutoSize = true;
            this.lblDepartPlatform.Location = new System.Drawing.Point(12, 87);
            this.lblDepartPlatform.Name = "lblDepartPlatform";
            this.lblDepartPlatform.Size = new System.Drawing.Size(66, 13);
            this.lblDepartPlatform.TabIndex = 4;
            this.lblDepartPlatform.Text = "Gleis/Kante:";
            // 
            // txbDepartPlatform
            // 
            this.txbDepartPlatform.Location = new System.Drawing.Point(142, 84);
            this.txbDepartPlatform.Name = "txbDepartPlatform";
            this.txbDepartPlatform.ReadOnly = true;
            this.txbDepartPlatform.Size = new System.Drawing.Size(200, 20);
            this.txbDepartPlatform.TabIndex = 4;
            this.txbDepartPlatform.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // txbArrivalPlatform
            // 
            this.txbArrivalPlatform.Location = new System.Drawing.Point(492, 84);
            this.txbArrivalPlatform.Name = "txbArrivalPlatform";
            this.txbArrivalPlatform.ReadOnly = true;
            this.txbArrivalPlatform.Size = new System.Drawing.Size(200, 20);
            this.txbArrivalPlatform.TabIndex = 8;
            this.txbArrivalPlatform.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblArrivalPlatform
            // 
            this.lblArrivalPlatform.AutoSize = true;
            this.lblArrivalPlatform.Location = new System.Drawing.Point(362, 87);
            this.lblArrivalPlatform.Name = "lblArrivalPlatform";
            this.lblArrivalPlatform.Size = new System.Drawing.Size(66, 13);
            this.lblArrivalPlatform.TabIndex = 10;
            this.lblArrivalPlatform.Text = "Gleis/Kante:";
            // 
            // txbArrival
            // 
            this.txbArrival.Location = new System.Drawing.Point(492, 58);
            this.txbArrival.Name = "txbArrival";
            this.txbArrival.ReadOnly = true;
            this.txbArrival.Size = new System.Drawing.Size(200, 20);
            this.txbArrival.TabIndex = 7;
            this.txbArrival.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(362, 61);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(64, 13);
            this.lblArrival.TabIndex = 8;
            this.lblArrival.Text = "Ankunft um:";
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(492, 32);
            this.txbTo.Name = "txbTo";
            this.txbTo.ReadOnly = true;
            this.txbTo.Size = new System.Drawing.Size(200, 20);
            this.txbTo.TabIndex = 6;
            this.txbTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(362, 35);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(36, 13);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "Nach:";
            // 
            // txbProducts
            // 
            this.txbProducts.Location = new System.Drawing.Point(142, 6);
            this.txbProducts.Name = "txbProducts";
            this.txbProducts.ReadOnly = true;
            this.txbProducts.Size = new System.Drawing.Size(200, 20);
            this.txbProducts.TabIndex = 0;
            this.txbProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(12, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(76, 13);
            this.lblProducts.TabIndex = 15;
            this.lblProducts.Text = "Verkehrsmittel:";
            // 
            // txbDuration
            // 
            this.txbDuration.Location = new System.Drawing.Point(492, 6);
            this.txbDuration.Name = "txbDuration";
            this.txbDuration.ReadOnly = true;
            this.txbDuration.Size = new System.Drawing.Size(200, 20);
            this.txbDuration.TabIndex = 1;
            this.txbDuration.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(362, 9);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(39, 13);
            this.lblDuration.TabIndex = 17;
            this.lblDuration.Text = "Dauer:";
            // 
            // btnViewStartLocation
            // 
            this.btnViewStartLocation.Location = new System.Drawing.Point(12, 110);
            this.btnViewStartLocation.Name = "btnViewStartLocation";
            this.btnViewStartLocation.Size = new System.Drawing.Size(330, 23);
            this.btnViewStartLocation.TabIndex = 5;
            this.btnViewStartLocation.Text = "Ort anzeigen (F1)";
            this.btnViewStartLocation.UseVisualStyleBackColor = true;
            this.btnViewStartLocation.Click += new System.EventHandler(this.btnViewStartLocation_Click);
            this.btnViewStartLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // btnViewEndLocation
            // 
            this.btnViewEndLocation.Location = new System.Drawing.Point(365, 110);
            this.btnViewEndLocation.Name = "btnViewEndLocation";
            this.btnViewEndLocation.Size = new System.Drawing.Size(330, 23);
            this.btnViewEndLocation.TabIndex = 9;
            this.btnViewEndLocation.Text = "Ort anzeigen (F2)";
            this.btnViewEndLocation.UseVisualStyleBackColor = true;
            this.btnViewEndLocation.Click += new System.EventHandler(this.btnViewEndLocation_Click);
            this.btnViewEndLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            // 
            // ConnectionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 143);
            this.Controls.Add(this.btnViewEndLocation);
            this.Controls.Add(this.btnViewStartLocation);
            this.Controls.Add(this.txbDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txbProducts);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.txbArrivalPlatform);
            this.Controls.Add(this.lblArrivalPlatform);
            this.Controls.Add(this.txbArrival);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txbDepartPlatform);
            this.Controls.Add(this.lblDepartPlatform);
            this.Controls.Add(this.txbDepart);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.txbFrom);
            this.Controls.Add(this.lblFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(723, 182);
            this.MinimumSize = new System.Drawing.Size(723, 182);
            this.Name = "ConnectionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖV-Applikation - Verbindung";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectionWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox txbDepart;
        private System.Windows.Forms.Label lblDepartPlatform;
        private System.Windows.Forms.TextBox txbDepartPlatform;
        private System.Windows.Forms.TextBox txbArrivalPlatform;
        private System.Windows.Forms.Label lblArrivalPlatform;
        private System.Windows.Forms.TextBox txbArrival;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txbProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txbDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnViewStartLocation;
        private System.Windows.Forms.Button btnViewEndLocation;
    }
}