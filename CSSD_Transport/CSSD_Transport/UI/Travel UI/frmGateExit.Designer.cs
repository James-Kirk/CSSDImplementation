namespace CSSD_Transport.UI.Travel_UI
{
    partial class frmGateExit
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
            this.btnExitGate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExitGate
            // 
            this.btnExitGate.Location = new System.Drawing.Point(63, 75);
            this.btnExitGate.Name = "btnExitGate";
            this.btnExitGate.Size = new System.Drawing.Size(159, 113);
            this.btnExitGate.TabIndex = 1;
            this.btnExitGate.Text = "Exit Gate";
            this.btnExitGate.UseVisualStyleBackColor = true;
            this.btnExitGate.Click += new System.EventHandler(this.btnExitGate_Click);
            // 
            // frmGateExit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnExitGate);
            this.Name = "frmGateExit";
            this.Text = "frnGateExit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitGate;
    }
}