namespace SwissTransportApp
{
    partial class MapWindow
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.wbbShow = new System.Windows.Forms.WebBrowser();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnOK);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 632);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(684, 29);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(12, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // wbbShow
            // 
            this.wbbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbbShow.Location = new System.Drawing.Point(0, 0);
            this.wbbShow.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbbShow.Name = "wbbShow";
            this.wbbShow.Size = new System.Drawing.Size(684, 632);
            this.wbbShow.TabIndex = 2;
            // 
            // MapWindow
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.wbbShow);
            this.Controls.Add(this.pnlFooter);
            this.Name = "MapWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ÖV-Applikation - Ort ansehen";
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.WebBrowser wbbShow;
    }
}