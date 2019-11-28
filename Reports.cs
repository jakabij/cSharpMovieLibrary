using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpMovieLibrary
{
    class Reports
    {
        public static List<string> GetMoviesBySomething(List<Movie> m,string userInput,string whatToSearch)
        {
            List<string> result = new List<string>();

            foreach (Movie element in m)
            {
                string searchedElement = null;
                bool toConvert = false;
                switch (whatToSearch)
                {
                    case "title":
                        searchedElement = element.Title;
                        break;

                    case "genres":
                        searchedElement = element.Genre;
                        break;

                    case "director":
                        searchedElement = element.Director;
                        break;

                    case "release_year":
                        searchedElement = element.ReleaseYear;
                        break;

                    case "stars":
                        searchedElement = element.Stars;
                        break;

                    case "imdb":
                        searchedElement = element.Imdb;
                        toConvert = true;
                        break;
                }
                if(toConvert==true)
                {
                    double userInputNumber = double.Parse(userInput);
                    if(double.Parse(searchedElement)>=userInputNumber)
                    {
                        result.Add(element.Title+": "+element.Imdb);
                    }
                }
                else
                {
                    if (searchedElement.ToLower().Contains(userInput.ToLower()))
                    {
                        result.Add(element.Title);
                    }
                }
  
            }
            return result;
        }

        public static List<string> GetBestImdb(List<Movie> movies)
        {
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
                    result.Add(row.Title+"  ("+row.Imdb+")");
                }
            }
            return result;
        }

    }
}
