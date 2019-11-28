using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpMovieLibrary
{
    class Reports
    {
        public static List<string> GetMoviesByGenre(List<Movie> m,string userInput)
        {
            List<string> result = new List<string>();
            foreach (Movie element in m)
            {
                if (element.Genre.Contains(userInput))
                {
                    result.Add(element.Title);
                }
            }
            return result;
        }

        public static void GetBestImdb(List<Movie> movies)
        {
            movies.
            foreach(Movie element in movies)
            {

            }
        }
    }
}
