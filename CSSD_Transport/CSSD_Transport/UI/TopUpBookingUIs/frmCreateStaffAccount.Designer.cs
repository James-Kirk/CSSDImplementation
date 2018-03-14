namespace CSSD_Transport.UI.TopUpBookingUIs
{
    partial class frmCreateStaffAccount
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblPassStrength = new System.Windows.Forms.Label();
            this.lblPassStrengthVal = new System.Windows.Forms.Label();
            this.lblPassMatch = new System.Windows.Forms.Label();
            this.lblPassMatchVal = new System.Windows.Forms.Label();
            this.btnCreateStaffAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(112, 75);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Username:";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(12, 129);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPass.TabIndex = 14;
            this.lblConfirmPass.Text = "Confirm Password:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(112, 126);
            this.txtConfirmPass.MaxLength = 50;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPass.TabIndex = 3;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // lblPassStrength
            // 
            this.lblPassStrength.AutoSize = true;
            this.lblPassStrength.Location = new System.Drawing.Point(26, 149);
            this.lblPassStrength.Name = "lblPassStrength";
            this.lblPassStrength.Size = new System.Drawing.Size(99, 13);
            this.lblPassStrength.TabIndex = 15;
            this.lblPassStrength.Text = "Password Strength:";
            // 
            // lblPassStrengthVal
            // 
            this.lblPassStrengthVal.AutoSize = true;
            this.lblPassStrengthVal.Location = new System.Drawing.Point(131, 149);
            this.lblPassStrengthVal.Name = "lblPassStrengthVal";
            this.lblPassStrengthVal.Size = new System.Drawing.Size(0, 13);
            this.lblPassStrengthVal.TabIndex = 16;
            // 
            // lblPassMatch
            // 
            this.lblPassMatch.AutoSize = true;
            this.lblPassMatch.Location = new System.Drawing.Point(26, 173);
            this.lblPassMatch.Name = "lblPassMatch";
            this.lblPassMatch.Size = new System.Drawing.Size(94, 13);
            this.lblPassMatch.TabIndex = 17;
            this.lblPassMatch.Text = "Passwords Match:";
            // 
            // lblPassMatchVal
            // 
            this.lblPassMatchVal.AutoSize = true;
            this.lblPassMatchVal.Location = new System.Drawing.Point(126, 173);
            this.lblPassMatchVal.Name = "lblPassMatchVal";
            this.lblPassMatchVal.Size = new System.Drawing.Size(0, 13);
            this.lblPassMatchVal.TabIndex = 18;
            // 
            // btnCreateStaffAccount
            // 
            this.btnCreateStaffAccount.Location = new System.Drawing.Point(183, 214);
            this.btnCreateStaffAccount.Name = "btnCreateStaffAccount";
            this.btnCreateStaffAccount.Size = new System.Drawing.Size(89, 35);
            this.btnCreateStaffAccount.TabIndex = 5;
            this.btnCreateStaffAccount.Text = "Create";
            this.btnCreateStaffAccount.UseVisualStyleBackColor = true;
            this.btnCreateStaffAccount.Click += new System.EventHandler(this.btnCreateStaffAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateStaffAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateStaffAccount);
            this.Controls.Add(this.lblPassMatchVal);
            this.Controls.Add(this.lblPassMatch);
            this.Controls.Add(this.lblPassStrengthVal);
            this.Controls.Add(this.lblPassStrength);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUser);
            this.Name = "frmCreateStaffAccount";
            this.Text = "frmCreateStaffAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblPassStrength;
        private System.Windows.Forms.Label lblPassStrengthVal;
        private System.Windows.Forms.Label lblPassMatch;
        private System.Windows.Forms.Label lblPassMatchVal;
        private System.Windows.Forms.Button btnCreateStaffAccount;
        private System.Windows.Forms.Button btnCancel;
    }
}