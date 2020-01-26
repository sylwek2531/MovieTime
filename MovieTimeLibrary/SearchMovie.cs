using System;
using MovieTime.Model;
using Newtonsoft.Json;

namespace MovieTimeLibrary
{
    //// <summary>
    /// The Movie Database API
    /// </summary>
    ///  <remarks> Pobieranie danych dotyczących danego endpointu</remarks>
   public class SearchMovie : Api
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


        /// <summary>
        /// Pobieranie teraz granych
        /// </summary>
        /// <returns>Zwraca dane o teraz granych</returns>
        public searchMoviesAsync getMoviesNowPlaying()
        {
            string path = "movie/now_playing";
            var response = GET(GetURI(path));
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
        /// <summary>
        /// Pobieranie Top
        /// </summary>
        /// <returns>Zwraca dane o top filmach</returns>
        public searchMoviesAsync getMoviesTopRated()
        {
            string path = "movie/top_rated";
            var response = GET(GetURI(path));
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

        /// <summary>
        /// Pobieranie popularnych
        /// </summary>
        /// <returns>Zwraca dane o popularnych</returns>
        public searchMoviesAsync getMoviesPopular()
        {
            string path = "movie/popular";
            var response = GET(GetURI(path));
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
        /// <summary>
        /// Nadchodzące
        /// </summary>
        /// <returns>Zwraca dane o nadchodzacych</returns>
        public searchMoviesAsync getMoviesUpcoming()
        {
            string path = "movie/upcoming";
            var response = GET(GetURI(path));
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