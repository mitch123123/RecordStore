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

        }
      
        private void MoviesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchByActorRdo.Checked)
            {
                HideGroups();
                ActorGroup.Show();
                DescriptionBox.Text = "";
                var sact = (ActorSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                ThumbnailBox.Load(MovieSearch.SetImageUrl(sact.profile_path, "medium"));
                var actdetails = ActorDetails.GetActorDetails(sact.id);
                AgeLbl.Text = ActorDetails.getage(actdetails.birthday);               
                GenderLbl.Text = ActorDetails.getGender(actdetails.gender);
                AliveLbl.Text = ActorDetails.Alive(actdetails.deathday);
                BornLbl.Text = actdetails.place_of_birth;
                PopularityActorLbl.Text = $"{sact.popularity }%";
                PopularityBar.Maximum = 100;
                PopularityBar.Value = (int)(sact.popularity);
                WebsiteLbl.Text = actdetails.homepage;
                PopularMoviesList.DataSource = sact.known_for;
            }
            else
            {
                HideGroups();
                MoviesGroup.Show();
                DescriptionBox.Text = "";
                var o = (MovieSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                ThumbnailBox.Load(MovieSearch.SetImageUrl(o.poster_path, "medium"));
                ReleaseLbl.Text = o.release_date.ToString();
                PopularPercentMovieLbl.Text = $"{o.popularity }%";
                PopularityBar.Maximum = 100;
                PopularityBar.Value = (int)(o.popularity);
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
            string movietitle = ((MovieSearch.Result)e.ListItem).title.ToString();
 
            e.Value = $"Title: {movietitle} ";
        }
        public void HideGroups()
        {
            MoviesGroup.Hide();
            ActorGroup.Hide();

        }

        private void BirthdayLbl_Click(object sender, EventArgs e)
        {

        }

        private void PopularMoviesList_Format(object sender, ListControlConvertEventArgs e)
        {
            string movietitle = ((ActorSearch.KnownFor)e.ListItem).title.ToString();
            string releasedate = ((ActorSearch.KnownFor)e.ListItem).release_date.ToString();
            e.Value = $"Title: {movietitle} | Release Date: {releasedate} ";
        }
    }
}
