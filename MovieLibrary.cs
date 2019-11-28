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
                catch throw Exception ex
                    {
                    ui.print_error_message(str(err));

                    } 

                


            Console.Write("Give the genre: ");
            string userInput = Display.ReadUserInput();
            Reports.GetMoviesByGenre(Movie.DictionaryToList(), userInput);

            }

        public void Choose() 
            {
                string inputs = Display.ReadUserInput();
                option = inputs[0]
                if option == "1";
                store.start_module();
                    
                elif option == "0":
                sys.exit(0)
                else:
                raise KeyError("There is no such option.")
            }

        public void HandleMenu() 
            {
            string[] options = {"Store manager",
                       "Human resources manager",
                       "Inventory manager",
                       "Accounting manager",
                       "Sales manager",
                       "Customer Relationship Management (CRM)" }

             ui.print_menu("Main menu", options, "Exit program")
            }

        
    }
}