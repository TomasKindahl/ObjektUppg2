using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektUppg2
{
    class Program
    {
        class DictEntry
        {
            public string swedish, english;
            public DictEntry(string eng, string swe)
            {
                swedish = swe; english = eng;
            }
        }
        static void Main(string[] args)
        {
            List<DictEntry> dict = new List<DictEntry>();

            using (StreamReader file = new StreamReader(@"D:\Users\tomas\ordlista.txt"))
            {
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    string[] words = line.Split('#');
                    // Console.WriteLine(line);
                    // Console.WriteLine("{0} - {1}", words[0], words[1]);
                    dict.Add(new DictEntry(words[0], words[1]));
                }
                file.Close();
            }

            Console.WriteLine("{0,-10}{1,-20}",
                              "english", "swedish");
            Console.WriteLine("-------------------");
            for (int i = 0; i < dict.Count(); i++)
            {
                if (dict[i] != null)
                {
                    Console.WriteLine("{0,-10}{1,-20}",
                                      dict[i].english, dict[i].swedish);
                }
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("Välkommen till ordlistan!");
            Console.WriteLine("Skriv 'sluta' för att sluta!");
            string command;
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if(command == "sluta")
                {
                    Console.WriteLine("Hej då!");
                }
                else
                {
                    Console.WriteLine($"Okänt kommando: {command}");
                }
            } while (command != "sluta");
        }
    }
}
