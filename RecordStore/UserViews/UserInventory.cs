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
        public List<UserMovie> userinv = new List<UserMovie>();
        public UserInventory(UserDatum curuser)
        {
            InitializeComponent();
            user = curuser;
            DescriptionBox.MaximumSize = new Size(400, 0);
            DescriptionBox.AutoSize = true;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }

        private void UserInventory_Load(object sender, EventArgs e)
        {
            UserLbl.Text = $"inventory for {user.Username}";
            using (var context = new MovieDatabaseContext())
            {
                 userinv = context.UserMovies.Where(a => a.UserId == user.UserId).ToList();
                 InventoryList.DataSource = userinv;
            }
            
        }

        private void InventoryList_Format(object sender, ListControlConvertEventArgs e)
        {
            string movietitle = ((UserMovie)e.ListItem).MovieTitle.ToString();
            string releasedate = ((UserMovie)e.ListItem).ReleaseDate.ToString("MM/dd/yyyy");
           // string desc = ((UserMovie)e.ListItem).MovieDesc.ToString();
            string price = ((UserMovie)e.ListItem).PurchasePrice.ToString("c2");    
            string genres = ((UserMovie)e.ListItem).Genre.ToString();


            e.Value = $"Title:{movietitle} | Release Date:{releasedate} | Purchase price:{price} | Genres:{genres}  ";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var search = SearchBox.Text;
             userinv = userinv.OrderByDescending(o => o.MovieTitle.StartsWith(search))
                     .ThenBy(o => o.MovieTitle).ToList();
            InventoryList.DataSource = userinv;
        }

        private void InventoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionBox.Text = "";
            UserMovie o = (UserMovie)InventoryList.Items[InventoryList.SelectedIndex];
            DescriptionBox.Text = o.MovieDesc;
        }
    }
}
