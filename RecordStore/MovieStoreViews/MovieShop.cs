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
            var genres = Genres.GetMovieGenres();
            GenresListbox.DataSource = genres;
            GenresListbox.DisplayMember = "name";
            //foreach (var genre in Genres.GetGenres())
            //{
            //    GenresListbox.Items.Add(genre.name);
            //}
            DescriptionBox.MaximumSize = new Size(600, 0);
            DescriptionBox.AutoSize = true;

        }
        private void MoviesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.MoviesList.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                AddCartBtn_Click();
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

          
            AddCartBtn_Click();
        }
        private void AddCartBtn_Click()
        {

            // user.usercart.movies.Add((UserMovie)MoviesList.SelectedValue );
            var selected_movie = (UserMovie)MoviesList.Items[MoviesList.SelectedIndex];
            if(user.CheckCart(selected_movie.MovieTitle, out var erritem))
            {
                ErrLbl.ForeColor =Color.Red;
                ErrLbl.Text = $"{erritem} is already in your cart";
            }
            else
            {
                ErrLbl.Text = "";
                user.usercart.movies.Add(selected_movie);
                CartList.DataSource = user.usercart.movies;
                CartList.DisplayMember = "movietitle";

            }

        }

        private void RemoveFromCartBtn_Click(object sender, EventArgs e)
        {
            var removeitem= CartList.Items[CartList.SelectedIndex];
            user.usercart.movies.Remove((UserMovie)removeitem);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
         
            searchedmovies = new List<UserMovie>();
            if(checkfilters(out var genrefilter))
            {
               
            }
            if (SearchByMovieRdo.Checked)
            {
                foreach (var movie in MovieSearch.GetMoviesByName(SearchBox.Text.ToString()))
                {
                    if (genrefilter)
                    {
                        foreach( var g in movie.genre_ids)
                        {
                            
                            foreach (Genres.Genre selecteditem in GenresListbox.CheckedItems)
                            {
                                int selectedGid = selecteditem.id;
                                if(selectedGid == g)
                                {
                                    searchedmovies.Add(new UserMovie(movie));
                                    break;
                                }
                            }
                             
                        }
                    }
                    else
                    {
                        searchedmovies.Add(new UserMovie(movie));
                    }
                       
                }

            }
            else
            {
                foreach (var movie in MovieSearch.GetMoviesByActor(SearchBox.Text.ToString()))
                {
                  
                    searchedmovies.Add(new UserMovie(movie));
                }
            }
            MoviesList.DataSource = searchedmovies;
            

        }

        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescriptionBox.Text = "";            
            UserMovie o= (UserMovie)MoviesList.Items[MoviesList.SelectedIndex];
            if(o.imageUrl!= null)
            {
                ThumbnailBox.Load(MovieSearch.SetImageUrl(o.imageUrl, "medium"));
            }
           
            DescriptionBox.Text =o.MovieDesc;
        }

        private void MoviesList_Format(object sender, ListControlConvertEventArgs e)
        {
            string movietitle = ((UserMovie)e.ListItem).MovieTitle.ToString();
            string releasedate = ((UserMovie)e.ListItem).ReleaseDate.ToString("MM/dd/yyyy");
            string price = ((UserMovie)e.ListItem).PurchasePrice.ToString("c2");


            e.Value = $"Title: {movietitle} | Release Date: {releasedate} | Price: {price} ";
        }
        

        private void ShowData()
        {
            CartList.DataSource = user.usercart.movies;
            CartList.DisplayMember = "moviename";
           
        }

        private void PopularBtn_Click(object sender, EventArgs e)
        {
            ConvertToSearchMovies("popular");
        }
        private void HighestRateBtn_Click(object sender, EventArgs e)
        {
            ConvertToSearchMovies("vote");       
        }
        
        private void ReleaseBtn_Click(object sender, EventArgs e)
        {
            ConvertToSearchMovies("release");
        }

        private void RevenueBtn_Click(object sender, EventArgs e)
        {
            ConvertToSearchMovies("revenue");
        }
        public void ConvertToSearchMovies(string parm)
        {
            searchedmovies = new List<UserMovie>();
            foreach (var movie in MovieSearch.GetSortedMovies(parm))
            {
                searchedmovies.Add(new UserMovie(movie));
            }
            MoviesList.DataSource = searchedmovies;
        }
        public bool checkfilters(out bool genreFilter)
        {
            if(GenresListbox.CheckedItems.Count > 0)
            {
                genreFilter = true;
                return true;
            }
            genreFilter = false;
            return false;
        }

    }
}
