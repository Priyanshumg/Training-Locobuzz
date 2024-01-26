using System;
/*
Question:
How to Reverse Each Word in a Given String in C#.
*/
namespace Array_Problems_7
{
    internal class Program
    {
        static string reverse(string WordToReverse)
        {
            char[] CharArray = WordToReverse.ToCharArray();
            Array.Reverse(CharArray);
            return new string(CharArray);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr= s.Split(' ');
                foreach (string element in arr)
                {
                    string word = reverse(element);
                    Console.Write($"{word} ");
                }
                Console.ReadLine();
        }
    }
}
