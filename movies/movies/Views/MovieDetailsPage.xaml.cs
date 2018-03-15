using System;
using System.Collections.Generic;
using movies.Models;
using Xamarin.Forms;

namespace movies.Views
{
    public partial class MovieDetailsPage : ContentPage
    {
        public MovieDetailsPage(Result movie)
        {
            InitializeComponent();

            img.Source = movie.PosterBig;
            title.Text = movie.title;
            overview.Text = movie.overview;
            releasedate.Text = movie.release_date.ToString();
            rating.Text = movie.vote_average.ToString();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
