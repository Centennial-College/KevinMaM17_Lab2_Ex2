using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KevinMaM17_Lab2_Ex2
{
    public partial class SimpleRegistrationUserControl : UserControl
    {
        public SimpleRegistrationUserControl()
        {
            InitializeComponent();
        }

        //Public Properties to expose the text property of the constituent controls in this custom user control
        //properties for group box title
        public string GroupBoxTitle
        {
            get { return this.registrationGroupBox.Text; }
            set { this.registrationGroupBox.Text = value; }
        }

        //properties for submit btn
        public string SubmitBtnText
        {
            get { return this.submitBtn.Text; }
            set { this.submitBtn.Text = value; }
        }

        //properties for cancel btn
        public string ClearBtnText
        {
            get { return this.clearBtn.Text; }
            set { this.clearBtn.Text = value; }
        }

        //READ-ONLY PROPERTIES
        public string Username
        {
            get { return this.usrnameTB.Text; }
        }

        public string Password
        {
            get { return this.pwdTB.Text; }
        }

        public string ConfirmPassword
        {
            get { return this.confirmPwdTB.Text; }
        }

        //EVENT HANDLERS

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.usrnameTB.Clear();
            this.pwdTB.Clear();
            this.confirmPwdTB.Clear();
            this.usrnameTB.BackColor = Color.White;
            this.pwdTB.BackColor = Color.White;
            this.confirmPwdTB.BackColor = Color.White;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //validate the three textboxes
            this.validateUsernameTB();
            this.validatePasswordTB();
            this.validateConfirmPasswordTB();

            //do any other special functions specific to classes using this user control.
            this.submitRegistrationForm();
        }

        private void validateConfirmPasswordTB()
        {
            //confirm pwd must match pwd textbox
            if (!this.ConfirmPassword.Equals(this.Password))
            {
                this.confirmPwdTB.BackColor = Color.Red;
            }
            else
            {
                this.confirmPwdTB.BackColor = Color.White;
            }
        }

        //declared regex obj to validate password
        Regex regExp = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");

        private void validatePasswordTB()
        {
            //validates password for following criteria:
            //at least on capital, at least one lowercase, at least one digit, at least one special char, at least 8 characters length

            if (!regExp.IsMatch(this.Password))
            {
                this.pwdTB.BackColor = Color.Red;
            }
            else
            {
                this.pwdTB.BackColor = Color.White;
            }
        }

        private void validateUsernameTB()
        {
            //checks for empty string
            if (this.Username.Length == 0)
            {
                this.usrnameTB.BackColor = Color.Red;
            }
            else
            {
                this.usrnameTB.BackColor = Color.White;
            }
        }

        //named this virtual so that other forms using this usercontrol can override the method and decide what to do when the form is submitted i.e. where the data is returned to.
        public virtual void submitRegistrationForm()
        {
            /**
             * Do something like the following?
             * Account tempAccount = new Account(this.Username, this.Password);
             */
        }
    }
}
