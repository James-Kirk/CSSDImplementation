namespace CSSD_Transport.UI
{
    partial class frmTrips
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
            this.lblMyTrips = new System.Windows.Forms.Label();
            this.lbxMyTrips = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyTrips
            // 
            this.lblMyTrips.AutoSize = true;
            this.lblMyTrips.Location = new System.Drawing.Point(13, 13);
            this.lblMyTrips.Name = "lblMyTrips";
            this.lblMyTrips.Size = new System.Drawing.Size(47, 13);
            this.lblMyTrips.TabIndex = 0;
            this.lblMyTrips.Text = "My Trips";
            // 
            // lbxMyTrips
            // 
            this.lbxMyTrips.FormattingEnabled = true;
            this.lbxMyTrips.Location = new System.Drawing.Point(12, 38);
            this.lbxMyTrips.Name = "lbxMyTrips";
            this.lbxMyTrips.Size = new System.Drawing.Size(316, 134);
            this.lbxMyTrips.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(41, 199);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(131, 37);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print Ticket(s)";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbxMyTrips);
            this.Controls.Add(this.lblMyTrips);
            this.Name = "frmTrips";
            this.Text = "frmTrips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyTrips;
        private System.Windows.Forms.ListBox lbxMyTrips;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
    }
}