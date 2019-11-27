using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpMovieLibrary
{
    class MovieLibrary
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>>  file=FileHandler.FileRead("movies.ini");
            Display.PrintAllData(file);
            List<Movie> listOfMovies = new List<Movie>();


            string genre = null;
            string director = null;
            string releaseYear = null;
            string stars = null;
            string imdb = null;

            foreach (string key in file.Keys)
            {
                string title = key;
                foreach(string element in file[key].Keys)
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

            string userInput = Display.readUserInput();
            Reports.GetMoviesByGenre(listOfMovies,userInput);


        }
    }
}