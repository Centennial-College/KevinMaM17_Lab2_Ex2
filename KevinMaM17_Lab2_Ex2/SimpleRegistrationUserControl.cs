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

        //properties for username
        public string Username
        {
            get { return this.usrnameTB.Text; }
            set { this.usrnameTB.Text = value; }
        }

        //properties for password
        public string Password
        {
            get { return this.pwdTB.Text; }
            set { this.pwdTB.Text = value; }
        }

        //properties for confirm password
        public string ConfirmPassword
        {
            get { return this.confirmPwdTB.Text; }
            set { this.confirmPwdTB.Text = value; }
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
    }
}
