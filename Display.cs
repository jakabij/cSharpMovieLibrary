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

        public static string ReadUserInput()
        {
            return Console.ReadLine();
        }

        public static void PrintResult(string resultText, string result)
        {
            Console.WriteLine(resultText+result);
        }

        public static void PrintMenu(string menu, string[] options, string exitMenu)
        {
            Console.WriteLine("      "+menu);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine((i+1) + ". " + options[i]);

            }
            Console.WriteLine("0. " + exitMenu);
        }
    }
}
