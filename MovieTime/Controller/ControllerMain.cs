﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
