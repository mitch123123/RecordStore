using homework9;
using MovieStore.Models;
using SharpDX.WIC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;

namespace MovieStore.MovieStoreViews
{
    public partial class SearchEverything : Form
    {
        public UserDatum user = new UserDatum();
        public List<MovieSearch.Result> searchedmovies = new List<MovieSearch.Result>();
        public List<TvSearch.Result> searchedTv = new List<TvSearch.Result>();
        public List<ActorSearch.Result> searchActors = new List<ActorSearch.Result>();
        public List<Genres.Genre> genres = new List<Genres.Genre>();
        public SearchEverything(UserDatum user)
        {
            InitializeComponent();
            this.user = user;
            genres = Genres.GetGenres();
            HideGroups();
            DescriptionBox.MaximumSize = new Size(600, 0);
            DescriptionBox.AutoSize = true;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
          
            if (SearchByMovieRdo.Checked)
            {
                searchedmovies = MovieSearch.GetMoviesByName(SearchBox.Text.ToString());
                MoviesList.DataSource = searchedmovies;
            }
            else if(SearchByActorRdo.Checked)
            {
                searchActors = ActorSearch.GetActors(SearchBox.Text.ToString());
                MoviesList.DataSource = searchActors;
            }
            else
            {
                searchedTv = TvSearch.GetTvShows(SearchBox.Text.ToString());
                MoviesList.DataSource = searchedTv;
            }

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }
      
        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchByActorRdo.Checked)
            {
                HideGroups();
                ActorGroup.Enabled = true;
                ActorGroup.Visible= true;
                ActorGroup.BringToFront();
                DescriptionBox.Text = "";
                var sact = (ActorSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                if(sact.profile_path != null)
                {
                    ThumbnailBox.Load(MovieSearch.SetImageUrl(sact.profile_path, "medium"));
                }
                else
                {
                    ThumbnailBox.Load("https://images.unsplash.com/photo-1544502062-f82887f03d1c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGVyc29uJTIwc2lsaG91ZXR0ZXxlbnwwfHwwfHw%3D&w=200&q=80");
                }
                
                var actdetails = ActorDetails.GetActorDetails(sact.id);
                AgeLbl.Text = ActorDetails.getage(actdetails.birthday);
                BirthdayLbl.Text = actdetails.birthday;
                GenderLbl.Text = ActorDetails.getGender(actdetails.gender);
                AliveLbl.Text = ActorDetails.Alive(actdetails.deathday);
                BornLbl.Text = actdetails.place_of_birth;
                DescriptionBox.Text = actdetails.biography;
                PopularityActorLbl.Text = $"{sact.popularity }%";
                ActorPopularbar.Maximum = 1000;
                ActorPopularbar.Value = (int)(sact.popularity);
                WebsiteLbl.Text = actdetails.homepage;
                PopularMoviesList.DataSource = sact.known_for;
            }else if (TvRdo.Checked)
            {

            }
            else
            {
                HideGroups();
                MoviesGroup.Enabled = true;
                MoviesGroup.Visible = true;
                MoviesGroup.BringToFront(); 
                DescriptionBox.Text = "";
                GenresMoviesList.Items.Clear();
                var o = (MovieSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                if(o.poster_path != null)
                {
                    ThumbnailBox.Load(MovieSearch.SetImageUrl(o.poster_path, "medium"));
                }
                else
                {
                    ThumbnailBox.Load("https://images.pexels.com/photos/356079/pexels-photo-356079.jpeg?cs=srgb&dl=pexels-pixabay-356079.jpg&fm=jpg&w=200&fit=max");
                }

                if (SearchByMovieRdo.Checked)
                {
                    var moviedetails = MovieDetails.GetMovieDetails(o.id);
                   
                    BudgetLbl.Text = moviedetails.budget.ToString("C");
                    RevenueLbl.Text = moviedetails.revenue.ToString("C");
                    EstProfitLbl.Text= (moviedetails.revenue - moviedetails.budget).ToString("C");
                    StatusLbl.Text = moviedetails.status;
                    TaglineLbl.Text = moviedetails.tagline;
                    RuntimeLbl.Text = $"{moviedetails.runtime} minutes";
                    WebsiteLbl.Text = moviedetails.homepage;
                    
                }
                
                ReleaseLbl.Text = o.release_date.ToString();             
                PopularPercentMovieLbl.Text = $"{o.GetPopularity((int)o.popularity)}";               
                RatingLbl.Text = $"{o.vote_average * 10}%";
                RatingBar.Maximum = 100;
                RatingBar.Value = (int)(o.vote_average * 10);
                VoteLbl.Text = o.vote_count.ToString();
                foreach (var genre in o.genre_ids)
                {
                    var s = genres.Find(x => x.id == genre);
                    GenresMoviesList.Items.Add(s.name);
                }
                DescriptionBox.Text = o.overview;
                ///need to get move extra details using moviegetdetails 
            }
            

        }

        private void MoviesList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (SearchByActorRdo.Checked)
            {
                if (((ActorSearch.Result)e.ListItem).name != null)
                {
                    string? Actorname = ((ActorSearch.Result)e.ListItem).name.ToString();
                    e.Value = $"Name: {Actorname} ";
                }
                
            }
            else if(SearchByMovieRdo.Checked)
            {
                if (((MovieSearch.Result)e.ListItem).title != null)
                {
                    string? movietitle = ((MovieSearch.Result)e.ListItem).title.ToString();
                    e.Value = $"Title: {movietitle} ";
                }
            }
            else
            {
                if(((TvSearch.Result)e.ListItem).title != null){
                    string? Tvtitle = ((TvSearch.Result)e.ListItem).title.ToString();
                    e.Value = $"Title: {Tvtitle} ";
                }
               
            }
            
        }
        public void HideGroups()
        {
            MoviesGroup.Visible= false;
            ActorGroup.Visible = false;
            MoviesGroup.Enabled=false;
            ActorGroup.Enabled=false;


        }

        private void BirthdayLbl_Click(object sender, EventArgs e)
        {

        }

        private void PopularMoviesList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (((ActorSearch.KnownFor)e.ListItem).title!= null)
            {
                string movietitle = ((ActorSearch.KnownFor)e.ListItem).title.ToString();
                string releasedate = ((ActorSearch.KnownFor)e.ListItem).release_date.ToString();
                e.Value = $"Title: {movietitle} | Release Date: {releasedate} ";
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
