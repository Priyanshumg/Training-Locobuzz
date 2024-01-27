using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Question: How to Reverse Each Word in a Given String in C#.
*/

namespace Array_Probelem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            ////char[] a = s.Split;
            //foreach (char c in s)
            //{
            //    Console.WriteLine(c);
            //}

            string s = Console.ReadLine();
            string a;
            a = s.Reverse();
            Console.WriteLine(s);
            Console.WriteLine($"Reveresed String: {}");
            Console.ReadLine();
        }
    }
}
