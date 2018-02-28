namespace CSSD_Transport.UI
{
    partial class frmInsertNoteSim
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn5Pounds
            // 
            this.btn5Pounds.Location = new System.Drawing.Point(12, 12);
            this.btn5Pounds.Name = "btn5Pounds";
            this.btn5Pounds.Size = new System.Drawing.Size(75, 40);
            this.btn5Pounds.TabIndex = 0;
            this.btn5Pounds.Text = "£5";
            this.btn5Pounds.UseVisualStyleBackColor = true;
            this.btn5Pounds.Click += new System.EventHandler(this.btn5Pounds_Click);
            // 
            // btn10Pounds
            // 
            this.btn10Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn10Pounds.Location = new System.Drawing.Point(103, 12);
            this.btn10Pounds.Name = "btn10Pounds";
            this.btn10Pounds.Size = new System.Drawing.Size(75, 40);
            this.btn10Pounds.TabIndex = 1;
            this.btn10Pounds.Text = "£10";
            this.btn10Pounds.UseVisualStyleBackColor = true;
            this.btn10Pounds.Click += new System.EventHandler(this.btn10Pounds_Click);
            // 
            // btn20Pounds
            // 
            this.btn20Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn20Pounds.Location = new System.Drawing.Point(12, 90);
            this.btn20Pounds.Name = "btn20Pounds";
            this.btn20Pounds.Size = new System.Drawing.Size(75, 40);
            this.btn20Pounds.TabIndex = 2;
            this.btn20Pounds.Text = "£20";
            this.btn20Pounds.UseVisualStyleBackColor = true;
            this.btn20Pounds.Click += new System.EventHandler(this.btn20Pounds_Click);
            // 
            // btn50Pounds
            // 
            this.btn50Pounds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn50Pounds.Location = new System.Drawing.Point(103, 90);
            this.btn50Pounds.Name = "btn50Pounds";
            this.btn50Pounds.Size = new System.Drawing.Size(75, 40);
            this.btn50Pounds.TabIndex = 3;
            this.btn50Pounds.Text = "£50";
            this.btn50Pounds.UseVisualStyleBackColor = true;
            this.btn50Pounds.Click += new System.EventHandler(this.btn50Pounds_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmInsertNoteSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn50Pounds);
            this.Controls.Add(this.btn20Pounds);
            this.Controls.Add(this.btn10Pounds);
            this.Controls.Add(this.btn5Pounds);
            this.Name = "frmInsertNoteSim";
            this.Text = "frmInsertNoteSim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5Pounds;
        private System.Windows.Forms.Button btn10Pounds;
        private System.Windows.Forms.Button btn20Pounds;
        private System.Windows.Forms.Button btn50Pounds;
        private System.Windows.Forms.Button btnCancel;
    }
}