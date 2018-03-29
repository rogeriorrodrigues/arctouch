using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Acr.UserDialogs;
using movies.Helpers;
using movies.Models;
using Xamarin.Forms.Extended;

namespace movies.ViewModels
{
    public class MovieViewModel : BaseViewModel
    {
        
        private const int PageSize = 20;
        readonly DataService _dataService = new DataService();

        public InfiniteScrollCollection<Result> Items { get; }

       

        public MovieViewModel(IUserDialogs dialogs)
        {
           
            Items = new InfiniteScrollCollection<Result>
            {
                OnLoadMore = async () =>
                {
                    IsBusy = true;


                    var page = Items.Count / PageSize;

                    var items = await _dataService.GetItemsAsync(page, PageSize);

                    IsBusy = false;


                    return items;
                },
                OnCanLoadMore = () =>
                {
                    return Items.Count > 0;
                }
            };

            DownloadDataAsync();
        }

        private async Task DownloadDataAsync()
        {
           
                var items = await _dataService.GetItemsAsync(pageIndex: 1, pageSize: PageSize);

                Items.AddRange(items);
           
           
        }


       
    }
}
