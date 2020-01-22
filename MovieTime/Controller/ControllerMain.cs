using MovieTime.API;
using MovieTime.Model;

namespace MovieTime.Controller
{
    /// <summary>
    /// Włączenie metody
    /// </summary>
    public class ControllerMain
    {
        /// <summary>
        /// Wyszukiwanie filmu
        /// </summary>
        /// <param name="MovieName">Tytuł filmu</param>
        /// <returns>Zwrócenie danych z zapytania</returns>
        public searchMoviesAsync getSearchMovie(string MovieName)
        {
            SearchMovie search = new SearchMovie();
            var getMovies = search.getMoviesByTitle(MovieName);
            return getMovies;
        }
        public searchMoviesAsync getNowPlaying()
        {
            SearchMovie nowPlaying = new SearchMovie();
            var getNowPlaying = nowPlaying.getMoviesNowPlaying();
            return getNowPlaying;
        }
        public searchMoviesAsync getTopRated()
        {
            SearchMovie topRated = new SearchMovie();
            var getTopRated = topRated.getMoviesTopRated();
            return getTopRated;

        }
        public searchMoviesAsync getPopular()
        {
            SearchMovie popular= new SearchMovie();
            var getPopular = popular.getMoviesPopular();
            return getPopular;

        }
        public searchMoviesAsync getUpcoming()
        {
            SearchMovie upcoming = new SearchMovie();
            var getTvShow = upcoming.getMoviesUpcoming();
            return getTvShow;

        }

    }
}
