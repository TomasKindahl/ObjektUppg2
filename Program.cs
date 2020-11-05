using System;
using System.Collections.Generic;
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
            dict.Add(new DictEntry("head", "huvud"));
            dict.Add(new DictEntry("see", "se"));
            dict.Add(new DictEntry("father", "far, pappa"));
            dict.Add(new DictEntry("tree", "träd"));
            dict.Add(new DictEntry("moon", "måne"));
            dict.Add(new DictEntry("move", "flytta"));
            dict.Add(new DictEntry("city", "stad"));
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
        }
    }
}
