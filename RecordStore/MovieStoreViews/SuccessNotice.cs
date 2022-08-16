using homework9;
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

namespace MovieStore.MovieStoreViews
{
    public partial class SuccessNotice : Form
    {
        public UserDatum user = new UserDatum();
       
       public SuccessNotice(UserDatum curuser)
        {
           
            InitializeComponent();
            user = curuser;

        }
        private void SuccessNotice_Load(object sender, EventArgs e)
        {
            successLBL.Text = $"successful checkout {user.Username}, you have added {user.usercart.movies.Count} to your library";
            Thread.Sleep(3000);          
            this.Hide();
            new UserMenu(user).Show();
        }
    }
}
