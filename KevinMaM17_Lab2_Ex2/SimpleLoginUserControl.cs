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
    public partial class SimpleLoginUserControl : UserControl
    {
        public SimpleLoginUserControl()
        {
            InitializeComponent();
        }

        //READ-ONLY PROPERTIES
        public string Username { get { return this.usrnameTB.Text; } }
        public string Password { get { return this.pwdTB.Text; } }

        //PUBLIC METHODS
        public void ClearAllTextBoxes()
        {
            this.usrnameTB.Clear();
            this.pwdTB.Clear();
        }

        public void ChangeUsernameBackgroundColor(Color c) => this.usrnameTB.BackColor = c;
        public void ChangePasswordBackgroundColor(Color c) => this.pwdTB.BackColor = c;
    }
}
