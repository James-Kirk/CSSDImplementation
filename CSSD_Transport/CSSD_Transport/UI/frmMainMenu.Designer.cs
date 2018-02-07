namespace CSSD_Transport.UI
{
    partial class frmMainMenu
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
            this.btnMyTrips = new System.Windows.Forms.Button();
            this.btnBookTickets = new System.Windows.Forms.Button();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyTrips
            // 
            this.btnMyTrips.Location = new System.Drawing.Point(82, 69);
            this.btnMyTrips.Name = "btnMyTrips";
            this.btnMyTrips.Size = new System.Drawing.Size(101, 39);
            this.btnMyTrips.TabIndex = 0;
            this.btnMyTrips.Text = "My Trips";
            this.btnMyTrips.UseVisualStyleBackColor = true;
            this.btnMyTrips.Click += new System.EventHandler(this.btnMyTrips_Click);
            // 
            // btnBookTickets
            // 
            this.btnBookTickets.Location = new System.Drawing.Point(82, 139);
            this.btnBookTickets.Name = "btnBookTickets";
            this.btnBookTickets.Size = new System.Drawing.Size(101, 39);
            this.btnBookTickets.TabIndex = 2;
            this.btnBookTickets.Text = "Book Tickets";
            this.btnBookTickets.UseVisualStyleBackColor = true;
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(82, 206);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(101, 39);
            this.btnTopUp.TabIndex = 4;
            this.btnTopUp.Text = "Top-Up";
            this.btnTopUp.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTopUp);
            this.Controls.Add(this.btnBookTickets);
            this.Controls.Add(this.btnMyTrips);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyTrips;
        private System.Windows.Forms.Button btnBookTickets;
        private System.Windows.Forms.Button btnTopUp;
    }
}