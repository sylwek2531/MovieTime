using MovieTime.API;
using MovieTime.Model;

namespace MovieTime.Controller
{
    public class ControllerMain
    {
        public searchMoviesAsync getSearchMovie(string MovieName)
        {
            SearchMovie search = new SearchMovie();
            var getMovies = search.getMoviesByTitle(MovieName);
            return getMovies;
        }
    }
}
