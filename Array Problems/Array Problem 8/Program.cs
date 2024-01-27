using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Question:
C# Program to sum up all the digits of a given number
 */
namespace Array_Problem_8
{
    internal class Program
    {
        static int sum_array(int[] array)
        {
            int sum_arr=0;
            foreach (int item in array)
            {
                sum_arr += item;
                Console.WriteLine(item);
            }
            return sum_arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            }
        }
    }
}
