namespace CSSD_Transport.UI
{
    partial class frmBegin
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
            this.btnBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBegin.Location = new System.Drawing.Point(46, 59);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(184, 141);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Touch To Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // frmBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnBegin);
            this.Name = "frmBegin";
            this.Text = "frmBegin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
    }
}