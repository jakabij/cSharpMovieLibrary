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

        public static List<string> GetBestImdb(List<Movie> movies)
        {
            //Console.WriteLine(movies[0]);
            List<string> result = new List<string>();
            double bestImdb = double.Parse(movies[0].Imdb);
            for(int row=1;row<movies.Count;row++)
            {
                if(double.Parse(movies[row].Imdb)>bestImdb)
                {
                    bestImdb = double.Parse(movies[row].Imdb);
                }
            }

            foreach(Movie row in movies)
            {
                if(double.Parse(row.Imdb)==bestImdb)
                {
                    result.Add(row.Title);
                }
            }
            return result;
        }

        public static double 
    }
}
