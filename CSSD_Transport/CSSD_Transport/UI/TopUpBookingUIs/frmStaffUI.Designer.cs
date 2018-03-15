namespace CSSD_Transport.UI
{
    partial class frmStaffUI
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
            this.components = new System.ComponentModel.Container();
            this.lsbJourneys = new System.Windows.Forms.ListBox();
            this.setOfJourneysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboStationFilter = new System.Windows.Forms.ComboBox();
            this.cboLineFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.dtpDateFilter = new System.Windows.Forms.DateTimePicker();
            this.ckbDateFilter = new System.Windows.Forms.CheckBox();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.ckbStationFilter = new System.Windows.Forms.CheckBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setOfJourneysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lsbJourneys
            // 
            this.lsbJourneys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbJourneys.FormattingEnabled = true;
            this.lsbJourneys.Location = new System.Drawing.Point(12, 12);
            this.lsbJourneys.Name = "lsbJourneys";
            this.lsbJourneys.Size = new System.Drawing.Size(578, 173);
            this.lsbJourneys.TabIndex = 0;
            // 
            // cboStationFilter
            // 
            this.cboStationFilter.FormattingEnabled = true;
            this.cboStationFilter.Location = new System.Drawing.Point(188, 240);
            this.cboStationFilter.Name = "cboStationFilter";
            this.cboStationFilter.Size = new System.Drawing.Size(121, 21);
            this.cboStationFilter.TabIndex = 1;
            // 
            // cboLineFilter
            // 
            this.cboLineFilter.FormattingEnabled = true;
            this.cboLineFilter.Location = new System.Drawing.Point(12, 240);
            this.cboLineFilter.Name = "cboLineFilter";
            this.cboLineFilter.Size = new System.Drawing.Size(121, 21);
            this.cboLineFilter.TabIndex = 2;
            this.cboLineFilter.SelectedIndexChanged += new System.EventHandler(this.cboLineFilter_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(515, 289);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 27);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(420, 289);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 27);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // dtpDateFilter
            // 
            this.dtpDateFilter.Location = new System.Drawing.Point(357, 241);
            this.dtpDateFilter.Name = "dtpDateFilter";
            this.dtpDateFilter.Size = new System.Drawing.Size(200, 20);
            this.dtpDateFilter.TabIndex = 5;
            // 
            // ckbDateFilter
            // 
            this.ckbDateFilter.AutoSize = true;
            this.ckbDateFilter.Location = new System.Drawing.Point(357, 218);
            this.ckbDateFilter.Name = "ckbDateFilter";
            this.ckbDateFilter.Size = new System.Drawing.Size(89, 17);
            this.ckbDateFilter.TabIndex = 6;
            this.ckbDateFilter.Text = "Filter By Date";
            this.ckbDateFilter.UseVisualStyleBackColor = true;
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(12, 188);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(138, 13);
            this.lblPassengers.TabIndex = 7;
            this.lblPassengers.Text = "Total Number Of Travelers: ";
            // 
            // ckbStationFilter
            // 
            this.ckbStationFilter.AutoSize = true;
            this.ckbStationFilter.Location = new System.Drawing.Point(188, 218);
            this.ckbStationFilter.Name = "ckbStationFilter";
            this.ckbStationFilter.Size = new System.Drawing.Size(99, 17);
            this.ckbStationFilter.TabIndex = 8;
            this.ckbStationFilter.Text = "Filter By Station";
            this.ckbStationFilter.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 289);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 27);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmStaffUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 328);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.ckbStationFilter);
            this.Controls.Add(this.lblPassengers);
            this.Controls.Add(this.ckbDateFilter);
            this.Controls.Add(this.dtpDateFilter);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cboLineFilter);
            this.Controls.Add(this.cboStationFilter);
            this.Controls.Add(this.lsbJourneys);
            this.Name = "frmStaffUI";
            this.Text = "frmStaffUI";
            ((System.ComponentModel.ISupportInitialize)(this.setOfJourneysBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource setOfJourneysBindingSource;
        private System.Windows.Forms.ListBox lsbJourneys;
        private System.Windows.Forms.ComboBox cboStationFilter;
        private System.Windows.Forms.ComboBox cboLineFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.CheckBox ckbDateFilter;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.CheckBox ckbStationFilter;
        private System.Windows.Forms.Button btnLogout;
    }
}