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
            this.txtTripDetails = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.lbxMyTrips.Size = new System.Drawing.Size(120, 95);
            this.lbxMyTrips.TabIndex = 1;
            // 
            // txtTripDetails
            // 
            this.txtTripDetails.Enabled = false;
            this.txtTripDetails.Location = new System.Drawing.Point(138, 38);
            this.txtTripDetails.Name = "txtTripDetails";
            this.txtTripDetails.Size = new System.Drawing.Size(134, 20);
            this.txtTripDetails.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print Ticket(s)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtTripDetails);
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
        private System.Windows.Forms.TextBox txtTripDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
    }
}