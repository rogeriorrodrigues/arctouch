using System;
using System.Threading.Tasks;
using System.Windows.Input;
using movies.Helpers;
using movies.Models;
using Xamarin.Forms;

namespace movies.ViewModels
{
    public class MovieDetailsViewModel : BaseViewModel
    {
        readonly DataService _dataService = new DataService();
        public ICommand MovieDetailsPropertyName { get; private set; }
       
        private readonly int _Id;

        public MovieDetailsViewModel(INavigation navigation, Result result) : base(navigation)
        {
            this._Id = result.id;

        }


        #region [ MovieDetails ]

        ICommand _MovieDetails;
     

        public ICommand MovieDetailsCommand => 
                _MovieDetails ?? (_MovieDetails = new Command(async () => await MovieDetailsExecute(_Id)));

        public async Task MovieDetailsExecute(int id)
        {
           
            try
            {
                if (this.IsBusy)
                    return;

                this.IsBusy = true;
                await _dataService.GetDetailsAsync(id);



            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Oops...", "Deu Ruim na conexão. Tente Novamente", "Ok");
            }
            finally
            {
                this.IsBusy = false;
               
            }

        }

        #endregion
    }
}
