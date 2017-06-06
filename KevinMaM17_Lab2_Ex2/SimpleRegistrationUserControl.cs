using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            throw new NotImplementedException();
        }

        private void validatePasswordTB()
        {
            throw new NotImplementedException();
        }

        private void validateUsernameTB()
        {
            throw new NotImplementedException();
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
