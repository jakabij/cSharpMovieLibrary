using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpMovieLibrary
{
    class MovieLibrary
    {
        public static Dictionary<string, Dictionary<string, string>> filenameToWrite = FileHandler.FileRead("movies.ini");

        static void Main(string[] args)
        {

            while (true)
            {
                HandleMenu();
                Choose();
            }
        }
        public static void Choose() 
            {
                string inputs = Display.ReadUserInput();
                
                if (inputs == "1")
                {
                    Console.Write("Give the genre: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by genre: ",Reports.GetMoviesBySomething(Movie.DictionaryToList(), userInput,"genres"));
                }

                else if (inputs == "2")
                {
                    Console.Write("Give the director: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by director ", Reports.GetMoviesBySomething(Movie.DictionaryToList(), userInput,"director"));
                }

                else if (inputs == "3")
                {
                    Console.Write("Give the year: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by year: ", Reports.GetMoviesBySomething(Movie.DictionaryToList(), userInput, "release_year"));
                }
                else if (inputs == "4")
                {
                    Console.Write("Give the actor/actress: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by the actor/actress: ", Reports.GetMoviesBySomething(Movie.DictionaryToList(), userInput,"stars"));
                }

                else if (inputs == "5")
                {
                    Console.Write("Give the imdb value (It will show the titles of movies that bigger than this imdb value): ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("", Reports.GetMoviesBySomething(Movie.DictionaryToList(), userInput, "imdb"));
                }

                else if (inputs == "6")
                {
                FileHandler.FileWrite("movies.ini",filenameToWrite);
                }
                else if (inputs == "0")
                {
                    System.Environment.Exit(0);
                }
                
                else
                {
                    Console.WriteLine("There is no option like that!\n\n");
                }
                
            }

        public static void HandleMenu() 
            {
                string[] options = {
                    "Movies by genre",
                    "Movies by director",
                    "Movies by release year",
                    "Movies by actors/actress",
                    "Movies by above imdb value",
                    "write to file"
                };

             Display.PrintMenu("Main menu", options, "Exit program");
            }

        
    }
}