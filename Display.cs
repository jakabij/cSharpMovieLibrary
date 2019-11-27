using System;
using System.Collections.Generic;

namespace cSharpMovieLibrary
{
    class Display
    {
        public static void PrintAllData(Dictionary<string, Dictionary<string, string>> file)
        {
            foreach (string key in file.Keys)
            {
                Console.WriteLine(key);
                foreach (string keyValue in file[key].Keys)
                {
                    Console.WriteLine
                        (keyValue + ": " + file[key][keyValue]);
                }
                Console.WriteLine();
            }
        }

        public static string readUserInput()
        {
            return Console.ReadLine();
        }
    }
}
