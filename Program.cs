using System;
using System.Collections.Generic;

namespace cs_con_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> openWith1 = new();

            openWith1.Add("txt", "notepad.exe");
            openWith1.Add("bmp", "paint.exe");
            openWith1.Add("dib", "paint.exe");
            openWith1.Add("rtf", "wordpad.exe");

            var openWith2 = new Dictionary<string, string>();

            openWith2.Add(".txt", "notepad");
            openWith2.Add(".bmp", "paint");
            openWith2.Add(".dib", "paint");
            openWith2.Add(".rtf", "wordpad");

            foreach (var pair in openWith1)
            {
                Console.WriteLine( $"KEY:{pair.Key} => VALUE:{pair.Value}" );
                Console.WriteLine( $"KEY:{pair.Key} => VALUE:{openWith1[pair.Key]}" );
            }

            var keyColl = openWith2.Keys;

            foreach (var key in keyColl )
            {
                Console.WriteLine( $"KEY:{key} => VALUE:{openWith2[key]}" );
            }

            var valueColl = openWith2.Values;

            foreach (var value in valueColl )
            {
                Console.WriteLine( $"VALUE:{value}" );
            }

        }
    }
}
