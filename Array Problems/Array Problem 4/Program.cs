using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Question:
Write a program in C# Sharp to find maximum and minimum element in an
array. 
*/
namespace Array_Problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int[] arr = { 2, 3, 1, 4, 5, 7, 8, 9 };
            int min = arr.Length;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < max)
                {
                    min = i;
                }
            }
            Console.WriteLine($"Max Value = {max}");
            Console.WriteLine($"Min Value = {min}");
        }
    }
}
