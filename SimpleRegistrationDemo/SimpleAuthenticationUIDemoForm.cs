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
    public partial class SimpleAuthenticationUIDemoForm : Form
    {

        //collection of Account objects
        List<Account> accList = new List<Account>();

        public SimpleAuthenticationUIDemoForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.simpleRegistrationUserControl.ClearAllTextBoxes();
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
                    this.simpleRegistrationUserControl.ClearAllTextBoxes();
                }
            }

            //resets the data bound source to update the newly added account record.
            this.accountsDataGridView.DataSource = null;
            this.accountsDataGridView.DataSource = accList;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.accountManagmenetTabControl.SelectedIndex = 0;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //validate credentials (check vs temp list of accounts)
            if ((accList.Where(accFound => accFound.Username.Equals(this.simpleLoginUserControl.Username) && accFound.Password.Equals(this.simpleLoginUserControl.Password))).Count() > 0)
            {
                MessageBox.Show($"User: {this.simpleLoginUserControl.Username} has successfully logged into the system.");
                this.simpleLoginUserControl.ClearAllTextBoxes();
            }
            else
            {
                MessageBox.Show($"ERROR - You have entered in an invalid username/password combination.\n\nPlease ensure you entered the correct credentials.");
                this.simpleLoginUserControl.ChangeUsernameBackgroundColor(Color.Red);
                this.simpleLoginUserControl.ChangePasswordBackgroundColor(Color.Red);
            }
        }

        private void accountManagmenetTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //on register, changing to login
            if (this.accountManagmenetTabControl.SelectedIndex == 1)
            {
                this.simpleRegistrationUserControl.ClearAllTextBoxes();
            }
            else
            {
                //on login, changing to register tab
                this.simpleLoginUserControl.ClearAllTextBoxes();
            }
        }
    }
}
