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
    public partial class EditUser : Form
    {
        public UserDatum user = new UserDatum();
        public EditUser()
        {
            InitializeComponent();
        }
        public EditUser(UserDatum curuser)
        {
            InitializeComponent();
            TimeLBL.Text = DateTime.Now.ToString("g");
            user = curuser;
            UserNameBox.Text = user.Username;
            
            AgeBox.Text = user.Age.ToString();
            PasswordBox.Text = user.Password;
            AccountBox.Text = user.AccountBalance.ToString();
            
            locationBox.Text = user.Location;

        }

        private void submitchangesBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            user.Username = UserNameBox.Text;
            var password = PasswordBox.Text;
           
           
            if (!user.getage(AgeBox.Text, out error))
            {
                ErrorLBL.ForeColor = Color.Red;
                ErrorLBL.Text = error;
            }
           
          
            user.getLocation();
            if (error == "")
            {
                if (UserDatum.tryUpdateUserEF(user, password, out error))
                {
                    ErrorLBL.ForeColor = Color.Green;
                    ErrorLBL.Text = "profile Updated succesfully";
                    Thread.Sleep(1000);
                    new UserMenu(user).Show();
                    this.Hide();
                }
                else
                {
                    ErrorLBL.ForeColor = Color.Red;
                    ErrorLBL.Text = error;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLBL.Text = DateTime.Now.ToString("g");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
