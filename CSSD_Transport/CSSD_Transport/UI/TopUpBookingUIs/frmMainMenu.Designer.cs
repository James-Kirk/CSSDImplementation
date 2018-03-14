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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMyTrips
            // 
            this.btnMyTrips.Location = new System.Drawing.Point(17, 53);
            this.btnMyTrips.Name = "btnMyTrips";
            this.btnMyTrips.Size = new System.Drawing.Size(101, 39);
            this.btnMyTrips.TabIndex = 0;
            this.btnMyTrips.Text = "My Trips";
            this.btnMyTrips.UseVisualStyleBackColor = true;
            this.btnMyTrips.Click += new System.EventHandler(this.btnMyTrips_Click);
            // 
            // btnBookTickets
            // 
            this.btnBookTickets.Location = new System.Drawing.Point(133, 53);
            this.btnBookTickets.Name = "btnBookTickets";
            this.btnBookTickets.Size = new System.Drawing.Size(101, 39);
            this.btnBookTickets.TabIndex = 2;
            this.btnBookTickets.Text = "Book Tickets";
            this.btnBookTickets.UseVisualStyleBackColor = true;
            this.btnBookTickets.Click += new System.EventHandler(this.btnBookTickets_Click);
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(17, 116);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(101, 39);
            this.btnTopUp.TabIndex = 4;
            this.btnTopUp.Text = "Top-Up";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(76, 25);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(133, 116);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(101, 39);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 184);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTopUp);
            this.Controls.Add(this.btnBookTickets);
            this.Controls.Add(this.btnMyTrips);
            this.Name = "frmMainMenu";
            this.Text = "|";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMyTrips;
        private System.Windows.Forms.Button btnBookTickets;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
    }
}