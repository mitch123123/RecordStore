
using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework9
{
    public partial class login : Form
    {
        public UserDatum user = new UserDatum();
        public login()
        {
            InitializeComponent();
        }

        private void NewUserLBL_Click(object sender, EventArgs e)
        {
            new NewUser().Show();
            this.Hide();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            var username = UsernameTxtBox.Text;
            var password = PassTxtBox.Text;
             user= UserDatum.LookupUserEF(username, password, out string error);
            if(error!= "" || user == null)
            {
                ErrorLBL.Text = error;
                ErrorLBL.ForeColor = Color.Red;
            }
            else
            {
                ErrorLBL.Text = "successful login";
                Thread.Sleep(1000);
                new UserMenu(user).Show();
                this.Hide();
            }
        }
        private void LoginBTN_Click()
        {
            var username = UsernameTxtBox.Text;
            var password = PassTxtBox.Text;
            user = UserDatum.LookupUserEF(username, password, out string error);
            if (error != "" || user == null)
            {
                ErrorLBL.Text = error;
                ErrorLBL.ForeColor = Color.Red;
            }
            else
            {
                ErrorLBL.Text = "successful login";
                Thread.Sleep(1000);
                new UserMenu(user).Show();
                this.Hide();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            timeLBL.Text = DateTime.Now.ToString("g");
        }

        private void PassTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                LoginBTN_Click();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLBL.Text = DateTime.Now.ToString("g");
        }
    }
}
