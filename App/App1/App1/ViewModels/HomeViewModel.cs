using App1.Models;
using App1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    //sealed: como não vai ser herdade por ngm, essa palavra bloqueia:
    public sealed class HomeViewModel : BaseViewModel
    {
        private readonly IMovieService movieService;

        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public HomeViewModel()
        {
            movieService = new MovieService();
        }

        public ObservableCollection<Movie> Movies
        {
            get => movies;
            set { movies = value; OnPropertyChanged(); }
        }

        public override async Task Initialize()
        {
            await ExecuteBusyAction(async () => {

                (var error, var upcomingMovies) = await movieService.GetUpcoming();

                if (error != null)
                {
                    await Application
                    .Current
                    .MainPage.DisplayAlert("Error", error, "Ok");

                    return;
                }

                Movies = new ObservableCollection<Movie>(upcomingMovies);

            });
        }
    }

}
