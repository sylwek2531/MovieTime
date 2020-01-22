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
    }
}
