﻿namespace KevinMaM17_Lab2_Ex2
{
    partial class SimpleRegistrationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrationGroupBox = new System.Windows.Forms.GroupBox();
            this.confirmPwdTB = new System.Windows.Forms.TextBox();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.pwdTB = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usrnameTB = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.registrationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrationGroupBox
            // 
            this.registrationGroupBox.Controls.Add(this.confirmPwdTB);
            this.registrationGroupBox.Controls.Add(this.confirmPasswordLbl);
            this.registrationGroupBox.Controls.Add(this.pwdTB);
            this.registrationGroupBox.Controls.Add(this.passwordLbl);
            this.registrationGroupBox.Controls.Add(this.usrnameTB);
            this.registrationGroupBox.Controls.Add(this.usernameLbl);
            this.registrationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.registrationGroupBox.Name = "registrationGroupBox";
            this.registrationGroupBox.Size = new System.Drawing.Size(481, 248);
            this.registrationGroupBox.TabIndex = 0;
            this.registrationGroupBox.TabStop = false;
            this.registrationGroupBox.Text = "Registration";
            // 
            // confirmPwdTB
            // 
            this.confirmPwdTB.Location = new System.Drawing.Point(223, 133);
            this.confirmPwdTB.Name = "confirmPwdTB";
            this.confirmPwdTB.Size = new System.Drawing.Size(231, 40);
            this.confirmPwdTB.TabIndex = 8;
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.confirmPasswordLbl.Location = new System.Drawing.Point(7, 139);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(216, 29);
            this.confirmPasswordLbl.TabIndex = 7;
            this.confirmPasswordLbl.Text = "Confirm Password:";
            // 
            // pwdTB
            // 
            this.pwdTB.Location = new System.Drawing.Point(223, 87);
            this.pwdTB.Name = "pwdTB";
            this.pwdTB.Size = new System.Drawing.Size(231, 40);
            this.pwdTB.TabIndex = 6;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passwordLbl.Location = new System.Drawing.Point(91, 93);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(126, 29);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password:";
            // 
            // usrnameTB
            // 
            this.usrnameTB.Location = new System.Drawing.Point(223, 41);
            this.usrnameTB.Name = "usrnameTB";
            this.usrnameTB.Size = new System.Drawing.Size(231, 40);
            this.usrnameTB.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(87, 47);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(130, 29);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username:";
            // 
            // SimpleRegistrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.registrationGroupBox);
            this.Name = "SimpleRegistrationUserControl";
            this.Size = new System.Drawing.Size(499, 261);
            this.registrationGroupBox.ResumeLayout(false);
            this.registrationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registrationGroupBox;
        private System.Windows.Forms.TextBox confirmPwdTB;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.TextBox pwdTB;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usrnameTB;
        private System.Windows.Forms.Label usernameLbl;
    }
}
