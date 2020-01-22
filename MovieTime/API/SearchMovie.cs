using MovieTime.Model;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MovieTime.API
{
    //// <summary>
    /// The Movie Database API
    /// </summary>
    ///  <remarks> Pobieranie danych dotyczących danego endpointu</remarks>
    class SearchMovie :Api
    { 
        public SearchMovie()
        {

        }
        /// <summary>
        /// Wyszukiwanie filmu poprzez tytuł
        /// </summary>
        /// <param name="searchTitle">Tytuł</param>
        /// <c>public searchMoviesAsync getMoviesByTitle(string searchTitle)</c>
        public searchMoviesAsync getMoviesByTitle(string searchTitle)
        {

            string path = "search/movie";
            var response = GET(GetURI(path) + "&query=" + searchTitle);
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                    return JsonConvert.DeserializeObject<searchMoviesAsync>(content);
            }
            else
            {
                return null;
            }
        }

    }
}
