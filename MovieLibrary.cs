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


                Console.Write("Give the genre: ");
                string userInput = Display.ReadUserInput();
                Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput);

            }
        }
        public static void Choose() 
            {
                string inputs = Display.ReadUserInput();
                
                if (inputs == "1")
                {
                    Console.Write("Give the genre: ");
                    string userInput = Display.ReadUserInput();
                    Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput);
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
                    "Store manager",
                    "Human resources manager",
                    "Inventory manager",
                    "Accounting manager",
                    "Sales manager",
                    "Customer Relationship Management (CRM)"
                };

             Display.PrintMenu("Main menu", options, "Exit program");
            }

        
    }
}