namespace CSSD_Transport.UI
{
    partial class frmInsertBillSim
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
            this.btn5Pounds = new System.Windows.Forms.Button();
            this.btn10Pounds = new System.Windows.Forms.Button();
            this.btn20Pounds = new System.Windows.Forms.Button();
            this.btn50Pounds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn5Pounds
            // 
            this.btn5Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn5Pounds.Location = new System.Drawing.Point(22, 27);
            this.btn5Pounds.Name = "btn5Pounds";
            this.btn5Pounds.Size = new System.Drawing.Size(78, 45);
            this.btn5Pounds.TabIndex = 0;
            this.btn5Pounds.Text = "£5";
            this.btn5Pounds.UseVisualStyleBackColor = true;
            // 
            // btn10Pounds
            // 
            this.btn10Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn10Pounds.Location = new System.Drawing.Point(118, 27);
            this.btn10Pounds.Name = "btn10Pounds";
            this.btn10Pounds.Size = new System.Drawing.Size(78, 45);
            this.btn10Pounds.TabIndex = 1;
            this.btn10Pounds.Text = "£10";
            this.btn10Pounds.UseVisualStyleBackColor = true;
            // 
            // btn20Pounds
            // 
            this.btn20Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn20Pounds.Location = new System.Drawing.Point(22, 109);
            this.btn20Pounds.Name = "btn20Pounds";
            this.btn20Pounds.Size = new System.Drawing.Size(78, 45);
            this.btn20Pounds.TabIndex = 2;
            this.btn20Pounds.Text = "£20";
            this.btn20Pounds.UseVisualStyleBackColor = true;
            // 
            // btn50Pounds
            // 
            this.btn50Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn50Pounds.Location = new System.Drawing.Point(118, 109);
            this.btn50Pounds.Name = "btn50Pounds";
            this.btn50Pounds.Size = new System.Drawing.Size(78, 45);
            this.btn50Pounds.TabIndex = 3;
            this.btn50Pounds.Text = "£50";
            this.btn50Pounds.UseVisualStyleBackColor = true;
            // 
            // frmInsertBillSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 174);
            this.Controls.Add(this.btn50Pounds);
            this.Controls.Add(this.btn20Pounds);
            this.Controls.Add(this.btn10Pounds);
            this.Controls.Add(this.btn5Pounds);
            this.Name = "frmInsertBillSim";
            this.Text = "frmInsertBillSim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5Pounds;
        private System.Windows.Forms.Button btn10Pounds;
        private System.Windows.Forms.Button btn20Pounds;
        private System.Windows.Forms.Button btn50Pounds;
    }
}