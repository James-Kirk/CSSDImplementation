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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.lblDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBoxStation
            // 
            this.cboBoxStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBoxStation.FormattingEnabled = true;
            this.cboBoxStation.Location = new System.Drawing.Point(641, 132);
            this.cboBoxStation.Name = "cboBoxStation";
            this.cboBoxStation.Size = new System.Drawing.Size(121, 21);
            this.cboBoxStation.TabIndex = 1;
            this.cboBoxStation.SelectedIndexChanged += new System.EventHandler(this.cboBoxStation_SelectedIndexChanged);
            // 
            // cboBoxLine
            // 
            this.cboBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBoxLine.FormattingEnabled = true;
            this.cboBoxLine.Location = new System.Drawing.Point(641, 64);
            this.cboBoxLine.Name = "cboBoxLine";
            this.cboBoxLine.Size = new System.Drawing.Size(121, 21);
            this.cboBoxLine.TabIndex = 2;
            this.cboBoxLine.SelectedIndexChanged += new System.EventHandler(this.cboBoxLine_SelectedIndexChanged);
            // 
            // lblCurrentStation
            // 
            this.lblCurrentStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentStation.AutoSize = true;
            this.lblCurrentStation.Location = new System.Drawing.Point(575, 17);
            this.lblCurrentStation.Name = "lblCurrentStation";
            this.lblCurrentStation.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentStation.TabIndex = 3;
            this.lblCurrentStation.Text = "Current Station: ";
            // 
            // lblDestination
            // 
            this.lblDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(574, 132);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(66, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination: ";
            // 
            // lblLineName
            // 
            this.lblLineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLineName.AutoSize = true;
            this.lblLineName.Location = new System.Drawing.Point(575, 64);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(33, 13);
            this.lblLineName.TabIndex = 5;
            this.lblLineName.Text = "Line: ";
            // 
            // btnTravel
            // 
            this.btnTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTravel.Location = new System.Drawing.Point(641, 219);
            this.btnTravel.Name = "btnTravel";
            this.btnTravel.Size = new System.Drawing.Size(121, 25);
            this.btnTravel.TabIndex = 6;
            this.btnTravel.Text = "Travel";
            this.btnTravel.UseVisualStyleBackColor = true;
            this.btnTravel.Click += new System.EventHandler(this.btnTravel_Click);
            // 
            // lblCurrentTravelCosts
            // 
            this.lblCurrentTravelCosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTravelCosts.AutoSize = true;
            this.lblCurrentTravelCosts.Location = new System.Drawing.Point(751, 17);
            this.lblCurrentTravelCosts.Name = "lblCurrentTravelCosts";
            this.lblCurrentTravelCosts.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentTravelCosts.TabIndex = 7;
            this.lblCurrentTravelCosts.Text = "Current Cost:  ";
            // 
            // lblNewCost
            // 
            this.lblNewCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewCost.AutoSize = true;
            this.lblNewCost.Location = new System.Drawing.Point(751, 39);
            this.lblNewCost.Name = "lblNewCost";
            this.lblNewCost.Size = new System.Drawing.Size(59, 13);
            this.lblNewCost.TabIndex = 8;
            this.lblNewCost.Text = "New Cost: ";
            // 
            // btnExitStation
            // 
            this.btnExitStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitStation.Location = new System.Drawing.Point(807, 219);
            this.btnExitStation.Name = "btnExitStation";
            this.btnExitStation.Size = new System.Drawing.Size(75, 25);
            this.btnExitStation.TabIndex = 9;
            this.btnExitStation.Text = "Exit Station";
            this.btnExitStation.UseVisualStyleBackColor = true;
            this.btnExitStation.Click += new System.EventHandler(this.btnExitStation_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(550, 551);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(12, 12);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(527, 527);
            this.map.TabIndex = 11;
            this.map.Zoom = 0D;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(574, 183);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 12;
            this.lblDistance.Text = "Distance: ";
            this.lblDistance.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmRailTravelSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 551);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.map);
            this.Controls.Add(this.splitter1);
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
            this.Load += new System.EventHandler(this.frmRailTravelSim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentStation;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.Button btnTravel;
        private System.Windows.Forms.Label lblCurrentTravelCosts;
        private System.Windows.Forms.Label lblNewCost;
        private System.Windows.Forms.Button btnExitStation;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.ComboBox cboBoxStation;
        public System.Windows.Forms.ComboBox cboBoxLine;
        public GMap.NET.WindowsForms.GMapControl map;
        public System.Windows.Forms.Label lblDistance;
    }
}