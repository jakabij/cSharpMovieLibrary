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
        public static List<Movie> DictionaryToList()
        {
            Dictionary<string, Dictionary<string, string>> file = FileHandler.FileRead("movies.ini");
            List<Movie> listOfMovies = new List<Movie>();


            string genre = null;
            string director = null;
            string releaseYear = null;
            string stars = null;
            string imdb = null;

            foreach (string key in file.Keys)
            {
                string title = key;
                foreach (string element in file[key].Keys)
                {
                    switch (element)
                    {
                        case "genres":
                            genre = file[key][element];
                            break;
                        case "director":
                            director = file[key][element];
                            break;
                        case "release_year":
                            releaseYear = file[key][element];
                            break;
                        case "stars":
                            stars = file[key][element];
                            break;
                        case "imdb":
                            imdb = file[key][element];
                            break;

                        default:
                            break;

                    }
                }
                Movie sampleMovie = new Movie(title, genre, director, releaseYear, stars, imdb);

                listOfMovies.Add(sampleMovie);

            }

            return listOfMovies;
        }
    }
}
