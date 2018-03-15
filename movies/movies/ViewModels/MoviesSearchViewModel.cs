using System;
using System.Threading.Tasks;
using movies.Helpers;
using movies.Models;
using Xamarin.Forms.Extended;
using System.ComponentModel;
using Xamarin.Forms;

namespace movies.ViewModels
{
    public class MoviesSearchViewModel : BaseViewModel
    {
        private const int PageSize = 10;
        readonly DataService _dataService = new DataService();

        public InfiniteScrollCollection<Result> Items { get; }

        private string _term;

        public Command SearchCommand { get; }

        public MoviesSearchViewModel()
        {
            //SearchCommand = new Command(() =>
            //{
                Items = new InfiniteScrollCollection<Result>
                {
                    OnLoadMore = async () =>
                    {
                        IsBusy = true;

                        var page = Items.Count / PageSize;

                        var items = await _dataService.GetSearchAsync(Term, page, PageSize);

                        IsBusy = false;


                        return items;
                    },
                    OnCanLoadMore = () =>
                    {
                        return Items.Count < 44;
                    }
                };

                DownloadDataAsync();
            //});
            

        }

        public string Term
        {
            get{
                return _term;
            }
            set{
                _term = value;
                OnPropertyChanged(Term);
            }

        }


        private async Task DownloadDataAsync()
        {
            var items = await _dataService.GetSearchAsync(query: Term ,pageIndex: 1, pageSize: PageSize);

            Items.AddRange(items);
        }
    }
}
