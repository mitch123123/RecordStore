using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework9.Models;
using MovieStore.Models;

namespace homework9
{
    public partial class NewUser : Form
    {
        public UserDatum user = new UserDatum();
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            user.getLocation();
            LocationBox.Text = user.Location;
        }

        private void submitchangesBtn_Click(object sender, EventArgs e)
        {
            string error="";
            user.UserId = Guid.NewGuid();
            user.Username = UserNameBox.Text;
            user.Password = PasswordBox.Text;
            user.AccountBalance = 500.00F;
            if(!user.getage(AgeBox.Text,out error))
            {
                ErrorLbl.ForeColor = Color.Red;
                ErrorLbl.Text = error;
            }
          
            if(error == "")
            {
                if (UserDatum.trycreateUserEF(user, out error))
                {
                    ErrorLbl.ForeColor = Color.Green;
                    ErrorLbl.Text = "profile created succesfully";
                    Thread.Sleep(1000);
                    new UserMenu(user).Show();
                    this.Hide();
                }
                else
                {
                    ErrorLbl.ForeColor = Color.Red;
                    ErrorLbl.Text = error;
                }
            }
           
        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackLbl_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void NewUser_Load_1(object sender, EventArgs e)
        {
            user.getLocation();
            LocationBox.Text = user.Location;
        }
    }
}
