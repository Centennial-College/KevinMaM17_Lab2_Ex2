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
                accList.Add(new Account(this.simpleRegistrationUserControl.Username, this.simpleRegistrationUserControl.Password));
                MessageBox.Show("added new account bc valid form!");
            }
            string accs = "Accounts in the accounts log:\n";
            foreach (Account acc in accList)
            {
                accs += $"{acc.Username}:{acc.Password}\n";
            }
                MessageBox.Show(accs);
            //this.accountsDataGridView.Update();
            //this.accountsDataGridView.Refresh();
        }

        private void SimpleRegistrationDemoForm_Load(object sender, EventArgs e)
        {
            //bind the list of account objects to the DataGridView
            BindingList<Account> bindingAccounts = new BindingList<Account>(accList);
            BindingSource dataSource = new BindingSource(bindingAccounts, null);
            this.accountsDataGridView.DataSource = dataSource;
        }
    }
}
