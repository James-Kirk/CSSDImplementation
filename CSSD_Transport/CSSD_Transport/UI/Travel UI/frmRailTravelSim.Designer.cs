namespace CSSD_Transport.UI.Travel_UI
{
    partial class frmRailTravelSim
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
            this.cboBoxStation = new System.Windows.Forms.ComboBox();
            this.cboBoxLine = new System.Windows.Forms.ComboBox();
            this.lblCurrentStation = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblLineName = new System.Windows.Forms.Label();
            this.btnTravel = new System.Windows.Forms.Button();
            this.lblCurrentTravelCosts = new System.Windows.Forms.Label();
            this.lblNewCost = new System.Windows.Forms.Label();
            this.btnExitStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboBoxStation
            // 
            this.cboBoxStation.FormattingEnabled = true;
            this.cboBoxStation.Location = new System.Drawing.Point(79, 128);
            this.cboBoxStation.Name = "cboBoxStation";
            this.cboBoxStation.Size = new System.Drawing.Size(121, 21);
            this.cboBoxStation.TabIndex = 1;
            this.cboBoxStation.SelectedIndexChanged += new System.EventHandler(this.cboBoxStation_SelectedIndexChanged);
            // 
            // cboBoxLine
            // 
            this.cboBoxLine.FormattingEnabled = true;
            this.cboBoxLine.Location = new System.Drawing.Point(79, 60);
            this.cboBoxLine.Name = "cboBoxLine";
            this.cboBoxLine.Size = new System.Drawing.Size(121, 21);
            this.cboBoxLine.TabIndex = 2;
            this.cboBoxLine.SelectedIndexChanged += new System.EventHandler(this.cboBoxLine_SelectedIndexChanged);
            // 
            // lblCurrentStation
            // 
            this.lblCurrentStation.AutoSize = true;
            this.lblCurrentStation.Location = new System.Drawing.Point(13, 13);
            this.lblCurrentStation.Name = "lblCurrentStation";
            this.lblCurrentStation.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentStation.TabIndex = 3;
            this.lblCurrentStation.Text = "Current Station: ";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 128);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(66, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination: ";
            // 
            // lblLineName
            // 
            this.lblLineName.AutoSize = true;
            this.lblLineName.Location = new System.Drawing.Point(13, 60);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(33, 13);
            this.lblLineName.TabIndex = 5;
            this.lblLineName.Text = "Line: ";
            // 
            // btnTravel
            // 
            this.btnTravel.Location = new System.Drawing.Point(79, 179);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(121, 25);
            this.btnTravel.TabIndex = 6;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // lblCurrentTravelCosts
            // 
            this.lblCurrentTravelCosts.AutoSize = true;
            this.lblCurrentTravelCosts.Location = new System.Drawing.Point(189, 13);
            this.lblCurrentTravelCosts.Name = "lblCurrentTravelCosts";
            this.lblCurrentTravelCosts.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentTravelCosts.TabIndex = 7;
            this.lblCurrentTravelCosts.Text = "Current Cost:  ";
            // 
            // lblNewCost
            // 
            this.lblNewCost.AutoSize = true;
            this.lblNewCost.Location = new System.Drawing.Point(189, 35);
            this.lblNewCost.Name = "lblNewCost";
            this.lblNewCost.Size = new System.Drawing.Size(59, 13);
            this.lblNewCost.TabIndex = 8;
            this.lblNewCost.Text = "New Cost: ";
            // 
            // btnExitStation
            // 
            this.btnExitStation.Location = new System.Drawing.Point(245, 179);
            this.btnExitStation.Name = "btnExitStation";
            this.btnExitStation.Size = new System.Drawing.Size(75, 25);
            this.btnExitStation.TabIndex = 9;
            this.btnExitStation.Text = "Exit Station";
            this.btnExitStation.UseVisualStyleBackColor = true;
            this.btnExitStation.Click += new System.EventHandler(this.btnExitStation_Click);
            // 
            // frmRailTravelSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 233);
            this.Controls.Add(this.btnExitStation);
            this.Controls.Add(this.lblNewCost);
            this.Controls.Add(this.lblCurrentTravelCosts);
            this.Controls.Add(this.btnTravel);
            this.Controls.Add(this.lblLineName);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblCurrentStation);
            this.Controls.Add(this.cboBoxLine);
            this.Controls.Add(this.cboBoxStation);
            this.Name = "frmRailTravelSim";
            this.Text = "frmRailTravelSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboBoxStation;
        private System.Windows.Forms.ComboBox cboBoxLine;
        private System.Windows.Forms.Label lblCurrentStation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Label lblCurrentTravelCosts;
        private System.Windows.Forms.Label lblNewCost;
        private System.Windows.Forms.Button btnExitStation;
    }
}