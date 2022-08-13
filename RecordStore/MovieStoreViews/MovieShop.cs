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
    public partial class MovieShop : Form
    {
        public UserDatum user { get; set; }
         
        public MovieShop(UserDatum curuser)
        {
            InitializeComponent();
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = "yyyy";
            DatePicker.ShowUpDown = true;
            user = curuser;
            CartList.DataSource = user.usercart.movies;
            foreach(var genre in Genres.GetGenres())
            {
                GenresListbox.Items.Add(genre);
            }
           
        }
        private void MoviesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.MoviesList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                user.usercart.movies.Add((UserMovie)MoviesList.Items[index]);
             
            }
        }
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }

        private void CheckoutBtn_Click(object sender, EventArgs e)
        {
            new CheckOut(user).Show();
            this.Hide();
        }

        private void AddCartBtn_Click(object sender, EventArgs e)
        {
           
          user.usercart.movies.Add((UserMovie)MoviesList.Items[MoviesList.SelectedIndex] );

            
        }

        private void RemoveFromCartBtn_Click(object sender, EventArgs e)
        {
            var removeitem= CartList.Items[CartList.SelectedIndex];
            user.usercart.movies.Remove((UserMovie)removeitem);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var searchedmovies = new List<UserMovie>();
            if (SearchByMovieRdo.Checked)
            {
                foreach (var movie in MovieSearch.GetMoviesByName(SearchBox.Text.ToString()))
                {
                    searchedmovies.Add(new UserMovie(movie));
                }
               
            }
            else
            {
                foreach (var movie in MovieSearch.GetMoviesByName(SearchBox.Text.ToString()))
                {
                    searchedmovies.Add(new UserMovie(movie));
                }
            }
            MoviesList.DataSource = searchedmovies;
        }

        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionBox.Items.Add(e.ToString());
        }
    }
}
