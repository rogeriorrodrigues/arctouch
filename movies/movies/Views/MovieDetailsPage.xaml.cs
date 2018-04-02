using System;
using System.Collections.Generic;
using movies.Models;
using movies.ViewModels;
using Xamarin.Forms;

namespace movies.Views
{
    public partial class MovieDetailsPage : ContentPage
    {
        MovieDetailsViewModel ViewModel => vm ?? (vm = BindingContext as MovieDetailsViewModel);
        MovieDetailsViewModel vm;

        public MovieDetailsPage(Result movie)
        {
            InitializeComponent();

            BindingContext = new MovieDetailsViewModel(Navigation , movie);
           
            ViewModel.MovieDetailsCommand.Execute(null);


           
          
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
