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
            if (this.simpleRegistrationUserControl.SubmitForm())
            {
                //check that Account object does not already exist in the list
                Account newAccount = new Account(this.simpleRegistrationUserControl.Username, this.simpleRegistrationUserControl.Password);

                //I wanted to practice using LINQ here that's why did not use built-in methods ;)
                if ((accList.Where(accFound => accFound.Username.Equals(this.simpleRegistrationUserControl.Username))).Count() > 0)
                {
                    MessageBox.Show($"Account already exists with the username: {newAccount.Username}!\n\nNew account was not registered.\n\nPlease use different Username.");
                }
                else
                {
                    accList.Add(newAccount);
                    MessageBox.Show($"The account with Username: {newAccount.Username} has been successfully registered!");
                    this.simpleRegistrationUserControl.ClearAll();
                }
            }

            //resets the data bound source to update the newly added account record.
            this.accountsDataGridView.DataSource = null;
            this.accountsDataGridView.DataSource = accList;
        }

        private void SimpleRegistrationDemoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
