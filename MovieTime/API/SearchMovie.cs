using MovieTime.Model;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MovieTime.API
{
    class SearchMovie:Api
    { 
        public SearchMovie()
        {

        }
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
