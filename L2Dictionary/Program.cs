using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // word - list of line numbers where that word is met
            var index = new SortedDictionary<string, List<int>>();
            string path = @"C:\Users\evhendax\source\repos\ITVDNCSharpProfessional\L2Dictionary\TheIdiot.txt";
            var lines = ReadFromFileToList(path);

            // algorithm of adding word with line numbers in dictionary
            for (int i = 0; i < lines.Count; i++)
            {
                string[] words = lines[i].Split(' ');
                foreach (var eachWord in words)
                {
                    string word = eachWord.ToLower();
                    if (index.ContainsKey(word))
                    {
                        index[word].Add(i);
                    }
                    else
                    {
                        // add new word and line number to dictionary
                        index.Add(word, new List<int> { i });
                    }
                }
            }
                       

            // output dictionary
            foreach (var indexLine in index)
            {
                Console.WriteLine();
                Console.Write(indexLine.Key + " - ");
                for (int i=0; i < indexLine.Value.Count; i++)
                {
                    string printLine = i != indexLine.Value.Count - 1 ? indexLine.Value[i].ToString() + ", " : indexLine.Value[i].ToString();
                    Console.Write(printLine);
                }

            }

            // Delay
            Console.ReadKey();

        }

        private static List<string> ReadFromFileToList(string path)
        {
            var lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return lines;
        }
    }
}
