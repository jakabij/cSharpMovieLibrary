using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpMovieLibrary
{
    class MovieLibrary
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>>  a=FileHandler.FileRead("movies.ini");
            
            foreach(string key in a.Keys)
            {
                Console.WriteLine(key);
                foreach(string keyValue in a[key].Keys)
                {
                    Console.WriteLine
                        (keyValue + ": "+a[key][keyValue]);
                }
                Console.WriteLine();
            }
            

        }
    }
}