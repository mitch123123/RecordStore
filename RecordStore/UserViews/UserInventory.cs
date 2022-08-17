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

namespace MovieStore.UserViews
{
    public partial class UserInventory : Form
    {
        public UserDatum user { get; set; } 
        public UserInventory(UserDatum curuser)
        {
            InitializeComponent();
            user = curuser;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }

        private void UserInventory_Load(object sender, EventArgs e)
        {
            using (var context = new MovieDatabaseContext())
            {
                var userinv = context.UserMovies.Where(a => a.UserId == user.UserId).ToList();
                InventoryList.DataSource = userinv;
            }
            
        }
    }
}
