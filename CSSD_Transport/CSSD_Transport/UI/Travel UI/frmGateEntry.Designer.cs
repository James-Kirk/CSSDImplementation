namespace CSSD_Transport.UI.Travel_UI
{
    partial class frmGateEntry
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
            this.btnEnterGate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterGate
            // 
            this.btnEnterGate.Location = new System.Drawing.Point(59, 65);
            this.btnEnterGate.Name = "btnEnterGate";
            this.btnEnterGate.Size = new System.Drawing.Size(159, 113);
            this.btnEnterGate.TabIndex = 0;
            this.btnEnterGate.Text = "Enter Gate";
            this.btnEnterGate.UseVisualStyleBackColor = true;
            this.btnEnterGate.Click += new System.EventHandler(this.btnEnterGate_Click);
            // 
            // frmGateEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEnterGate);
            this.Name = "frmGateEntry";
            this.Text = "frmGateEntry";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGate;
    }
}