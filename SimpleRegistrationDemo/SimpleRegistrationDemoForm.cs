using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRegistrationDemo
{
    public partial class SimpleRegistrationDemoForm : Form
    {

        //collection of Account objects
        List<Account> accList = new List<Account>();

        public SimpleRegistrationDemoForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.simpleRegistrationUserControl.ClearAll();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.simpleRegistrationUserControl.SubmitForm();
            accList.Add(new Account(this.simpleRegistrationUserControl.Username, this.simpleRegistrationUserControl.Password));
            //MessageBox.Show(accList.ToString());
        }
    }
}
