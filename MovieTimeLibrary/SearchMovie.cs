﻿using System;
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