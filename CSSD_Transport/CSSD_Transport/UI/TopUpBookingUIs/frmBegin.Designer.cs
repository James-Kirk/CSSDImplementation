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
            this.btnEnter = new System.Windows.Forms.Button();
            this.cbxBeginLine = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStart = new System.Windows.Forms.ComboBox();
            this.btnStaffLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBegin.Location = new System.Drawing.Point(50, 12);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(184, 67);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Login Screen";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEnter.Location = new System.Drawing.Point(50, 97);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(184, 67);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter Gate";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbxBeginLine
            // 
            this.cbxBeginLine.FormattingEnabled = true;
            this.cbxBeginLine.Location = new System.Drawing.Point(108, 181);
            this.cbxBeginLine.Name = "cbxBeginLine";
            this.cbxBeginLine.Size = new System.Drawing.Size(121, 21);
            this.cbxBeginLine.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start:";
            // 
            // cbxStart
            // 
            this.cbxStart.FormattingEnabled = true;
            this.cbxStart.Location = new System.Drawing.Point(108, 211);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(121, 21);
            this.cbxStart.TabIndex = 5;
            // 
            // btnStaffLogin
            // 
            this.btnStaffLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStaffLogin.Location = new System.Drawing.Point(50, 268);
            this.btnStaffLogin.Name = "btnStaffLogin";
            this.btnStaffLogin.Size = new System.Drawing.Size(184, 67);
            this.btnStaffLogin.TabIndex = 6;
            this.btnStaffLogin.Text = "Staff Login";
            this.btnStaffLogin.UseVisualStyleBackColor = true;
            this.btnStaffLogin.Click += new System.EventHandler(this.btnStaffLogin_Click);
            // 
            // frmBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 377);
            this.Controls.Add(this.btnStaffLogin);
            this.Controls.Add(this.cbxStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxBeginLine);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnBegin);
            this.Name = "frmBegin";
            this.Text = "frmBegin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cbxBeginLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStart;
        private System.Windows.Forms.Button btnStaffLogin;
    }
}