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
            
           
            

        }
    }
}