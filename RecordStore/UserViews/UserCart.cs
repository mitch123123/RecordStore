using homework9;
using MovieStore.Models;
using MovieStore.MovieStoreViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore.UserViews
{
    public partial class UserCart : Form
    {
        public UserDatum user { get; set; }
        public UserCart(UserDatum curuser)
        {
            InitializeComponent();
            user = curuser;
            UserLbl.Text = $"shopping cart items for {user.Username}";
            CartItemsList.DataSource = user.usercart.movies;
        }

        private void rtnBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }

        private void RtnShopingBtn_Click(object sender, EventArgs e)
        {
            new MovieShop(user).Show();
            this.Hide();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            new CheckOut(user).Show();
            this.Hide();
        }
    }
}
