using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpMovieLibrary
{
    class Reports
    {
        public static void GetMoviesByGenre(List<Movie> m,string userInput)
        {
            foreach (Movie element in m)
            {
                if (element.Genre.Contains(userInput))
                {
                    Console.WriteLine(element.Genre+": "+element.Title);
                }
            }

        }
    }
}
