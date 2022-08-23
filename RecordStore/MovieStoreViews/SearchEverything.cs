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
        public List<Genres.Genre> moviegenres = new List<Genres.Genre>();
        public List<Genres.Genre> tvgenres = new List<Genres.Genre>();
        public SearchEverything(UserDatum user)
        {
            InitializeComponent();
            this.user = user;
            moviegenres = Genres.GetMovieGenres();
            tvgenres = Genres.GetTvGenres();
            HideGroups();
            DescriptionBox.MaximumSize = new Size(600, 0);
            DescriptionBox.AutoSize = true;
            SoverviewLbl.MaximumSize = new Size(400, 0);
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
                Init("actor",out var basicobj,out var detailedobj );
                var sact = (ActorSearch.Result)basicobj;
                var actdetails = (ActorDetails.Root)detailedobj;
                loadThumbnail(sact.profile_path,ThumbnailBox, "medium");
               
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
                Init("tv", out var obj, out var detailedobj);              
                var tvshow = (TvSearch.Result)obj;
                var tvdetails = (TvDetails.Root)detailedobj;
                loadThumbnail(tvshow.poster_path,ThumbnailBox, "medium");
                LoadGenres(TVGenresList, tvshow, "tv");               
                tvPoularityLbl.Text = $"{MovieSearch.Result.GetPopularity((int)tvshow.popularity)}";
                TvratingLbl.Text = $"{tvshow.vote_average * 10}%";
                TvRatingbar.Maximum = 100;
                TvRatingbar.Value = (int)(tvshow.vote_average * 10);
                TvVoteLbll.Text = tvshow.vote_count.ToString();               
                DescriptionBox.Text = tvshow.overview;
                FirstEpisodeLbl.Text = tvdetails.first_air_date;
                CreatedList.DataSource = tvdetails.created_by;
                EpisodesLbl.Text = $"{tvdetails.number_of_episodes} episodes";
                double avg = Queryable.Average(tvdetails.episode_run_time.AsQueryable());
                EpisodeLengthLbl.Text = $"{avg} min";
                SeasonsList.DataSource = tvdetails.seasons;
            }
            else
            {
                Init("movie", out var obj, out var detailedobj);
                var movie = (MovieSearch.Result)obj;
                var moviedetails = (MovieDetails.Root)detailedobj;
                loadThumbnail(movie.poster_path, ThumbnailBox, "medium");
                LoadGenres(GenresMoviesList, movie, "movie");
                
                BudgetLbl.Text = moviedetails.budget.ToString("C");
                RevenueLbl.Text = moviedetails.revenue.ToString("C");
                EstProfitLbl.Text= (moviedetails.revenue - moviedetails.budget).ToString("C");
                StatusLbl.Text = moviedetails.status;
                TaglineLbl.Text = moviedetails.tagline;
                RuntimeLbl.Text = $"{moviedetails.runtime} minutes";
                WebsiteLbl.Text = moviedetails.homepage;
                ReleaseLbl.Text = movie.release_date.ToString();             
                PopularPercentMovieLbl.Text = $"{MovieSearch.Result.GetPopularity((int)movie.popularity)}";               
                RatingLbl.Text = $"{movie.vote_average * 10}%";
                RatingBar.Maximum = 100;
                RatingBar.Value = (int)(movie.vote_average * 10);
                VoteLbl.Text = movie.vote_count.ToString();
                
                DescriptionBox.Text = movie.overview;
              
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
                if(((TvSearch.Result)e.ListItem).name != null){
                    string? Tvtitle = ((TvSearch.Result)e.ListItem).name.ToString();
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
            TvBox.Visible=false;
            TvBox.Enabled=false;
            SeasonDetailGroup.Visible=false;
            SeasonDetailGroup.Enabled=false;


        }
        public void LoadGenres(ListBox list, object obj, string type)
        {
            if (type == "movie"){
                var movie = (MovieSearch.Result)obj;
                foreach (var genre in movie.genre_ids)
                {
                    var s = moviegenres.Find(x => x.id == genre);
                    list.Items.Add(s.name);
                }
            }
            else
            {
                var tvshow = (TvSearch.Result)obj;
                foreach (var genre in tvshow.genre_ids)
                {
                    var s = tvgenres.Find(x => x.id == genre);
                    list.Items.Add(s.name);
                }
            }
           
        }
      
        public void loadThumbnail(string profile_path, PictureBox box,string size)
        {
            if (profile_path != null)
            {
                box.Load(MovieSearch.SetImageUrl(profile_path, size));
            }
            else
            {
                box.Load("https://images.unsplash.com/photo-1544502062-f82887f03d1c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cGVyc29uJTIwc2lsaG91ZXR0ZXxlbnwwfHwwfHw%3D&w=200&q=80");
            }
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
        public void Init(string type, out object obj, out object detailobj)
        {
            HideGroups();
            if (type == "actor")
            {
                
                ActorGroup.Enabled = true;
                ActorGroup.Visible = true;
                ActorGroup.BringToFront();
                DescriptionBox.Text = "";
                
                obj = (ActorSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                var searchobj = (ActorSearch.Result)obj;
                detailobj  = ActorDetails.GetActorDetails(searchobj.id);
            }
            else if(type == "tv")
            {
               
                TvBox.Enabled = true;
                TvBox.Visible = true;
                SeasonDetailGroup.Enabled = true;
                SeasonDetailGroup.Visible = true;
                TvBox.BringToFront();
                DescriptionBox.Text = "";
                TVGenresList.Items.Clear();
                obj = (TvSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                var searchobj = (TvSearch.Result)obj;
                detailobj = TvDetails.GetTvDetails(searchobj.id);
            }
            else
            {
                
                MoviesGroup.Enabled = true;
                MoviesGroup.Visible = true;
                MoviesGroup.BringToFront();
                DescriptionBox.Text = "";
                GenresMoviesList.Items.Clear();
                obj = (MovieSearch.Result)MoviesList.Items[MoviesList.SelectedIndex];
                var searchobj = (MovieSearch.Result)obj;
                detailobj = MovieDetails.GetMovieDetails(searchobj.id);
            }
           
        }
        

        private void CreatedList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (((TvDetails.CreatedBy)e.ListItem).name != null)
            {
                string name = ((TvDetails.CreatedBy)e.ListItem).name.ToString();
               
                e.Value = $"{name}";
            }
        }

        private void CreatedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (TvDetails.CreatedBy)CreatedList.Items[CreatedList.SelectedIndex];
            loadThumbnail(obj.profile_path,SeasonImage, "supersmall");
        }

        private void SeasonsList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (((TvDetails.Season)e.ListItem).name != null)
            {
               
                string seasonnum = ((TvDetails.Season)e.ListItem).season_number.ToString();
                e.Value = $"Season {seasonnum}";
            }
        }

        private void SeasonsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obj = (TvDetails.Season)SeasonsList.Items[SeasonsList.SelectedIndex];
            loadThumbnail(obj.poster_path, SeasonImage, "supersmall");
            SairdateLbl.Text = obj.air_date;
            SepisodeCountLbl.Text = obj.episode_count.ToString();
            SoverviewLbl.Text = obj.overview;
        }
    }
}
