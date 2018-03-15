using System;
using System.Collections.Generic;
using movies.Helpers;
using movies.Models;
using movies.ViewModels;
using Xamarin.Forms;

namespace movies.Views
{
    public partial class MoveisListPage : ContentPage
    {
        public MoveisListPage()
        {
            InitializeComponent();

           // BindingContext = new MovieViewModel();

            // = BindingContext;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var movie = ((ListView)sender).SelectedItem as Result;
            if (movie == null)
                return;

            await Navigation.PushModalAsync(new NavigationPage(new MovieDetailsPage(movie)), true);


        }
    }
}
