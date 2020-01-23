using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieTimeLibrary;

namespace MovieTime.Controller.Tests
{
    [TestClass()]
    public class ControllerMainTests
    {
        [TestMethod()]
        [DataRow("Spider man")]
        public void getSearchMovieTest(string MovieName)
        {
            SearchMovie search = new SearchMovie();
            var getMovies = search.getMoviesByTitle(MovieName);
            Assert.IsNotNull(getMovies);

        }

        [TestMethod()]
        public void getNowPlayingTest()
        {
            SearchMovie nowPlaying = new SearchMovie();
            var getNowPlaying = nowPlaying.getMoviesNowPlaying();          
            Assert.IsNotNull(getNowPlaying);
        }

        [TestMethod()]
        public void getTopRatedTest()
        {
            SearchMovie topRated = new SearchMovie();
            var getTopRated = topRated.getMoviesTopRated();
            Assert.IsNotNull(getTopRated);
        }

        [TestMethod()]
        public void getPopularTest()
        {
            SearchMovie popular = new SearchMovie();
            var getPopular = popular.getMoviesPopular();
            Assert.IsNotNull(getPopular);
        }

        [TestMethod()]
        public void getUpcomingTest()
        {
            SearchMovie upcoming = new SearchMovie();
            var getTvShow = upcoming.getMoviesUpcoming();
            Assert.IsNotNull(getTvShow);

        }
    }
}