using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpMovieLibrary
{
    class Movies
    {
        public string Title { get; }
        public string Genre { get; }
        public string Director { get; }
        public int ReleaseYear { get; }
        public string Stars { get; }
        public double Imdb { get; }
        
        public Movies(string title,string genre, string director, int releaseYear, string stars, double imdb)
        {
            Title = title;
            Genre = genre;
            Director = director;
            ReleaseYear = releaseYear;
            Stars = stars;
            Imdb = imdb;
        }
    }
}
