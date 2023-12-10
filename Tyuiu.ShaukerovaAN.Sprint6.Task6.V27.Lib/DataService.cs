using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShaukerovaAN.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string words = ""; ;
            using (StreamReader reader = new StreamReader(path))
            {
                bool first = true;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] linewords = line.Split(' ');
                    foreach (string word in linewords)
                    {
                        if (word.Contains('H'))
                        {
                            if (first == true)
                            {
                                words += word;
                                first = false;
                            }
                            else
                            {
                                words = words + " " + word;
                            }
                        }
                    }
                }
            }
            return words;
        }
    }
}


