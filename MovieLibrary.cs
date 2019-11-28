using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpMovieLibrary
{
    class MovieLibrary
    {
        static void Main(string[] args)
        {

            while (true)
            {
                HandleMenu();
                try
                {
                    Choose();
                }
                catch (Exception)
                {
                    throw;

                }

                             
            }
        }
        public static void Choose() 
            {
                string inputs = Display.ReadUserInput();
                
                if (inputs == "1")
                {
                    Console.Write("Give the genre: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by genre: ",Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput));
                }

                else if (inputs == "2")
                {
                    Console.Write("Give the director: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by genre: ", Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput));
                }

                else if (inputs == "3")
                {
                    Console.Write("Give the year: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by genre: ", Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput));
                }
                else if (inputs == "4")
                {
                    Console.Write("Give the actor/actress: ");
                    string userInput = Display.ReadUserInput();
                    Display.PrintListResult("Movies by genre: ", Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput));
                }
                else if (inputs == "0")
                {
                    System.Environment.Exit(0);
                }
                
                else
                {
                    throw new Exception("Noooooooooooooooo.");
                }
                
            }

        public static void HandleMenu() 
            {
                string[] options = {
                    "Movies by genre",
                    "Movies by director",
                    "Movies by release year",
                    "Movies by actors/actress",
                    
                };

             Display.PrintMenu("Main menu", options, "Exit program");
            }

        
    }
}