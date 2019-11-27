using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpMovieLibrary
{
    class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string ReleaseYear { get; set; }
        public string Stars { get; set; }
        public string Imdb { get; set; }

        public List<String> GetProperties()
        {
            List<String> list = new List<String>();
            list.Add(Title);
            list.Add(Genre);
            list.Add(Director);
            list.Add(ReleaseYear);
            list.Add(Stars);
            list.Add(Imdb);
            return list;
            }

        public Movie(string title,string genre, string director, string releaseYear, string stars, string imdb)
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
