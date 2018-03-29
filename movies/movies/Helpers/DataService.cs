using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using movies.Models;
using Newtonsoft.Json;

namespace movies.Helpers
{
    public class DataService
    {
        HttpClient client = new HttpClient();
       
        public async Task<IList<Result>> GetItemsAsync(int pageIndex, int pageSize)
        {

            //Fazendo um GET no serviço

            string sURL = Settings.ApiUrl + "/movie/popular?api_key="+ Settings.ApiKey +"&language="+ Settings.Language +"&page="+ pageIndex +"";
            var uri = new Uri(string.Format(sURL));
            //Classe para deserializar o retorno
            var resultMovies = new MovieResults();

            try
            {
                var responsepaci = await client.GetAsync(uri);

                //verificando se o status code é OK
                if (responsepaci.IsSuccessStatusCode)
                {
                    //pegando o retorno de lendo em async
                    var content = responsepaci.Content.ReadAsStringAsync().Result;


                    //deserializando o conteudo para a classe result
                    resultMovies = JsonConvert.DeserializeObject<MovieResults>(content);

                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }


            return resultMovies.results;

        }

        public async Task<MovieDetailsResult> GetDetailsAsync(int movieId)
        {

            //Fazendo um GET no serviço

            string sURL = Settings.ApiUrl + "/movie/"+ movieId +"?api_key="+ Settings.ApiKey +"&language="+ Settings.Language +"";
            var uri = new Uri(string.Format(sURL));

            //Classe para deserializar o retorno
            var resultMoviesDetails = new MovieDetailsResult();

            try
            {
                var responsepaci = await client.GetAsync(uri);

                //verificando se o status code é OK
                if (responsepaci.IsSuccessStatusCode)
                {
                    //pegando o retorno de lendo em async
                    var content = responsepaci.Content.ReadAsStringAsync().Result;


                    //deserializando o conteudo para a classe result
                    resultMoviesDetails = JsonConvert.DeserializeObject<MovieDetailsResult>(content);

                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return resultMoviesDetails;
        }

        public async Task<IList<Result>> GetSearchAsync(string query, int pageIndex, int pageSize)
        {
 
            //Fazendo um GET no serviço

            string sURL = Settings.ApiUrl + "/search/movie?api_key=" + Settings.ApiKey + "&language=" + Settings.Language + "&query="+ query +"&include_adult=false&page=" + pageIndex + "";
            var uri = new Uri(string.Format(sURL));

            //Classe para deserializar o retorno
            var resultMovies = new MovieResults();

            try
            {
                var responsepaci = await client.GetAsync(uri);

                //verificando se o status code é OK
                if (responsepaci.IsSuccessStatusCode)
                {
                    //pegando o retorno de lendo em async
                    var content = responsepaci.Content.ReadAsStringAsync().Result;

                    //deserializando o conteudo para a classe result
                    resultMovies = JsonConvert.DeserializeObject<MovieResults>(content);

                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }

            return resultMovies.results;
        }
    }
}
