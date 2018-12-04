namespace SwissTransportApp
{
    partial class DepartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartWindow));
            this.lblFrom = new System.Windows.Forms.Label();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.txbGoal = new System.Windows.Forms.TextBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.txbDepart = new System.Windows.Forms.TextBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.txbOrganisation = new System.Windows.Forms.TextBox();
            this.lblOrganisation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnViewLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 41);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Von:";
            // 
            // txbFrom
            // 
            this.txbFrom.Location = new System.Drawing.Point(106, 38);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.ReadOnly = true;
            this.txbFrom.Size = new System.Drawing.Size(200, 20);
            this.txbFrom.TabIndex = 1;
            this.txbFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            // 
            // txbGoal
            // 
            this.txbGoal.Location = new System.Drawing.Point(106, 64);
            this.txbGoal.Name = "txbGoal";
            this.txbGoal.ReadOnly = true;
            this.txbGoal.Size = new System.Drawing.Size(200, 20);
            this.txbGoal.TabIndex = 2;
            this.txbGoal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(6, 67);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(27, 13);
            this.lblGoal.TabIndex = 2;
            this.lblGoal.Text = "Ziel:";
            // 
            // txbDepart
            // 
            this.txbDepart.Location = new System.Drawing.Point(106, 90);
            this.txbDepart.Name = "txbDepart";
            this.txbDepart.ReadOnly = true;
            this.txbDepart.Size = new System.Drawing.Size(200, 20);
            this.txbDepart.TabIndex = 3;
            this.txbDepart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(6, 93);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(44, 13);
            this.lblDepart.TabIndex = 4;
            this.lblDepart.Text = "Abfahrt:";
            // 
            // txbOrganisation
            // 
            this.txbOrganisation.Location = new System.Drawing.Point(106, 116);
            this.txbOrganisation.Name = "txbOrganisation";
            this.txbOrganisation.ReadOnly = true;
            this.txbOrganisation.Size = new System.Drawing.Size(200, 20);
            this.txbOrganisation.TabIndex = 4;
            this.txbOrganisation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            // 
            // lblOrganisation
            // 
            this.lblOrganisation.AutoSize = true;
            this.lblOrganisation.Location = new System.Drawing.Point(6, 119);
            this.lblOrganisation.Name = "lblOrganisation";
            this.lblOrganisation.Size = new System.Drawing.Size(69, 13);
            this.lblOrganisation.TabIndex = 6;
            this.lblOrganisation.Text = "Organisation:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(106, 12);
            this.txbName.Name = "txbName";
            this.txbName.ReadOnly = true;
            this.txbName.Size = new System.Drawing.Size(200, 20);
            this.txbName.TabIndex = 0;
            this.txbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            // 
            // btnViewLocation
            // 
            this.btnViewLocation.Location = new System.Drawing.Point(9, 147);
            this.btnViewLocation.Name = "btnViewLocation";
            this.btnViewLocation.Size = new System.Drawing.Size(297, 23);
            this.btnViewLocation.TabIndex = 9;
            this.btnViewLocation.Text = "Ort der Startstation anzeigen";
            this.btnViewLocation.UseVisualStyleBackColor = true;
            this.btnViewLocation.Click += new System.EventHandler(this.btnViewLocation_Click);
            // 
            // DepartWindow
            // 
            this.AcceptButton = this.btnViewLocation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 179);
            this.Controls.Add(this.btnViewLocation);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbOrganisation);
            this.Controls.Add(this.lblOrganisation);
            this.Controls.Add(this.txbDepart);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.txbGoal);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.txbFrom);
            this.Controls.Add(this.lblFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(342, 218);
            this.MinimumSize = new System.Drawing.Size(342, 218);
            this.Name = "DepartWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abfahrt - ÖV-Applikation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DepartWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.TextBox txbGoal;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.TextBox txbDepart;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.TextBox txbOrganisation;
        private System.Windows.Forms.Label lblOrganisation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnViewLocation;
    }
}