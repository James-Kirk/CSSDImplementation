namespace CSSD_Transport.UI.TopUpBookingUIs
{
    partial class frmBookTicket
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
            this.lblLine = new System.Windows.Forms.Label();
            this.lblStartLocation = new System.Windows.Forms.Label();
            this.lblDestinationName = new System.Windows.Forms.Label();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.lblBookingCost = new System.Windows.Forms.Label();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnCalculateCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(12, 64);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(30, 13);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "Line:";
            // 
            // lblStartLocation
            // 
            this.lblStartLocation.AutoSize = true;
            this.lblStartLocation.Location = new System.Drawing.Point(12, 94);
            this.lblStartLocation.Name = "lblStartLocation";
            this.lblStartLocation.Size = new System.Drawing.Size(32, 13);
            this.lblStartLocation.TabIndex = 1;
            this.lblStartLocation.Text = "Start:";
            // 
            // lblDestinationName
            // 
            this.lblDestinationName.AutoSize = true;
            this.lblDestinationName.Location = new System.Drawing.Point(12, 123);
            this.lblDestinationName.Name = "lblDestinationName";
            this.lblDestinationName.Size = new System.Drawing.Size(63, 13);
            this.lblDestinationName.TabIndex = 2;
            this.lblDestinationName.Text = "Destination:";
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboLine.Location = new System.Drawing.Point(81, 61);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(121, 21);
            this.cboLine.TabIndex = 3;
            this.cboLine.SelectedIndexChanged += new System.EventHandler(this.cboLine_SelectedIndexChanged);
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Location = new System.Drawing.Point(81, 91);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(121, 21);
            this.cboStart.TabIndex = 4;
            // 
            // cboDestination
            // 
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(81, 120);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(121, 21);
            this.cboDestination.TabIndex = 5;
            // 
            // lblBookingCost
            // 
            this.lblBookingCost.AutoSize = true;
            this.lblBookingCost.Location = new System.Drawing.Point(12, 29);
            this.lblBookingCost.Name = "lblBookingCost";
            this.lblBookingCost.Size = new System.Drawing.Size(85, 13);
            this.lblBookingCost.TabIndex = 6;
            this.lblBookingCost.Text = "Cost of Booking:";
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.Location = new System.Drawing.Point(15, 210);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(75, 34);
            this.btnCancelBook.TabIndex = 7;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = true;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(112, 209);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(90, 35);
            this.btnConfirmBooking.TabIndex = 8;
            this.btnConfirmBooking.Text = "Confirm Booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCalculateCost
            // 
            this.btnCalculateCost.Location = new System.Drawing.Point(15, 167);
            this.btnCalculateCost.Name = "btnCalculateCost";
            this.btnCalculateCost.Size = new System.Drawing.Size(75, 37);
            this.btnCalculateCost.TabIndex = 9;
            this.btnCalculateCost.Text = "Calculate Cost";
            this.btnCalculateCost.UseVisualStyleBackColor = true;
            this.btnCalculateCost.Click += new System.EventHandler(this.btnCalculateCost_Click);
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 256);
            this.Controls.Add(this.btnCalculateCost);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.lblBookingCost);
            this.Controls.Add(this.cboDestination);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.cboLine);
            this.Controls.Add(this.lblDestinationName);
            this.Controls.Add(this.lblStartLocation);
            this.Controls.Add(this.lblLine);
            this.Name = "frmBookTicket";
            this.Text = "frmBookTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblStartLocation;
        private System.Windows.Forms.Label lblDestinationName;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.ComboBox cboStart;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label lblBookingCost;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCalculateCost;
    }
}