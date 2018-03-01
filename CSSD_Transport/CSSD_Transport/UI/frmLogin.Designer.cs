namespace CSSD_Transport.UI
{
    partial class frmLogin
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSimSmartCard = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimSmartCard
            // 
            this.btnSimSmartCard.Location = new System.Drawing.Point(12, 199);
            this.btnSimSmartCard.Name = "btnSimSmartCard";
            this.btnSimSmartCard.Size = new System.Drawing.Size(112, 37);
            this.btnSimSmartCard.TabIndex = 0;
            this.btnSimSmartCard.Text = "Simulate Smart Card";
            this.btnSimSmartCard.UseVisualStyleBackColor = true;
            this.btnSimSmartCard.Click += new System.EventHandler(this.btnSimSmartCard_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(92, 47);
            this.txtPin.MaxLength = 4;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 1;
            this.txtPin.UseSystemPasswordChar = true;
            this.txtPin.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(145, 199);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 37);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnSimSmartCard);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSimSmartCard;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnConfirm;
    }
}