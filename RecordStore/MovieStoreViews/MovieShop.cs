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
       // public Dictionary<string,UserMovie> searchedMovies { get; set; }
      
        public List<UserMovie> searchedmovies { get; set; }
        public MovieShop(UserDatum curuser)
        {
            user = curuser;
            user.usercart.movies = new BindingList<UserMovie>();
            InitializeComponent();
            ShowData();
            DatePicker.Format = DateTimePickerFormat.Custom;
            DatePicker.CustomFormat = "yyyy";
            DatePicker.ShowUpDown = true;
        
            var genres = Genres.GetGenres();
            GenresListbox.DataSource = genres;
            GenresListbox.DisplayMember = "name";
            //foreach (var genre in Genres.GetGenres())
            //{
            //    GenresListbox.Items.Add(genre.name);
            //}
            DescriptionBox.MaximumSize = new Size(400, 0);
            DescriptionBox.AutoSize = true;

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

            // user.usercart.movies.Add((UserMovie)MoviesList.SelectedValue );
            user.usercart.movies.Add((UserMovie)MoviesList.Items[MoviesList.SelectedIndex]);
            CartList.DataSource = user.usercart.movies;
            CartList.DisplayMember = "movietitle";

        }

        private void RemoveFromCartBtn_Click(object sender, EventArgs e)
        {
            var removeitem= CartList.Items[CartList.SelectedIndex];
            user.usercart.movies.Remove((UserMovie)removeitem);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           // searchedMovies = new Dictionary<string, UserMovie>();
            searchedmovies = new List<UserMovie>();

            if (SearchByMovieRdo.Checked)
            {
                foreach (var movie in MovieSearch.GetMoviesByName(SearchBox.Text.ToString()))
                {
                    //   var keyobj = new UserMovie(movie);
                    //   var keystring = $"Title:{keyobj.MovieTitle} | Release Date:{keyobj.ReleaseDate} | Price:{keyobj.PurchasePrice} ";
                    //   searchedMovies.Add(keystring,keyobj);
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
            // MoviesList.DataSource = new BindingSource(searchedMovies, null);
            // MoviesList.DisplayMember = "Key";
            //  MoviesList.ValueMember = "Value";
            MoviesList.DataSource = searchedmovies;
            

        }

        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionBox.Text = "";
           UserMovie o= (UserMovie)MoviesList.Items[MoviesList.SelectedIndex];   
            DescriptionBox.Text =o.MovieDesc;
        }

        private void MoviesList_Format(object sender, ListControlConvertEventArgs e)
        {
            string movietitle = ((UserMovie)e.ListItem).MovieTitle.ToString();
            string releasedate = ((UserMovie)e.ListItem).ReleaseDate.ToString("MM/dd/yyyy");
            string price = ((UserMovie)e.ListItem).PurchasePrice.ToString();


            e.Value = $"Title:{movietitle} | Release Date:{releasedate} | Price:{price} ";
        }
        

        private void ShowData()
        {
            CartList.DataSource = user.usercart.movies;
            CartList.DisplayMember = "moviename";
           
        }
    }
}
