using MovieStore;
using MovieStore.Models;
using MovieStore.MovieStoreViews;
using MovieStore.UserViews;
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
    public partial class UserMenu : Form
    {
        public UserDatum user = new UserDatum();
        public UserMenu()
        {
            InitializeComponent();
        }
        public UserMenu(UserDatum fromuser)
        {
            InitializeComponent();
            user = fromuser;
        }

        private void EditPrfBtn_Click(object sender, EventArgs e)
        {
            new EditUser(user).Show();
            this.Hide();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            welcomeLBL.Text = $"welcome {user.Username}";
            TimeLBL.Text = DateTime.Now.ToString("g");
        }

        private void LogOffBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void TransactionsBtn_Click(object sender, EventArgs e)
        {
            new UserTransactions(user).Show();
            this.Hide();
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            new  UserInventory(user).Show();
            this.Hide();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            new MovieShop(user).Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLBL.Text = DateTime.Now.ToString("g");
        }

        private void SearchMovieBtn_Click(object sender, EventArgs e)
        {
            //  new ViewMeals(user).Show();
            this.Hide();
        }

        private void ReturnMovieBtn_Click(object sender, EventArgs e)
        {
            //  new ViewMeals(user).Show();
            this.Hide();
        }
    }
}
