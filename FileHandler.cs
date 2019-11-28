using System;
using System.Collections.Generic;
using System.IO;

namespace cSharpMovieLibrary
{
    public class FileHandler
    {
        public static Dictionary<string, Dictionary<string, string>> FileRead(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader("movies.ini");
                var database = new Dictionary<string, Dictionary<string, string>>();
                
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var d2 = new Dictionary<string, string>();
                    var d = new Dictionary<string, string>();

                    if (line.StartsWith("["))
                    {
                        string title = line.Substring(line.IndexOf("[") + 1, line.IndexOf("]")-1);
                        
                        for (int i = 0; i < 5; i++)
                        {
                            line = sr.ReadLine();
                            if (line.Contains("="))
                            {
                                string[] s1 = line.Split("=");
                               
                                string key = s1[0];
                                string value = s1[1];
                                d.Add(key, value);
                       
                            }

                            foreach (string k in d.Keys)
                            {
                                d2.Add(k, d[k]);
                            }
                            d.Clear();
                        }
                        database.Add(title, d2);

                    }
                }
                sr.Close();
                return database;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Szopd ki!"+ ex);
            }

            return null;
        }

        public static Boolean FileWrite(string filename, Dictionary<string, Dictionary<string, string>> moviesDatabase)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (String titleKey in moviesDatabase.Keys)
                {
                    sw.WriteLine("[" + titleKey + "]");
                    foreach  (string item in moviesDatabase[titleKey].Keys)
                    {
                        sw.WriteLine(item +"="+ moviesDatabase[titleKey][item]);
                    }
                    sw.WriteLine();
                }
            }

            return false;

        }
    }
}
