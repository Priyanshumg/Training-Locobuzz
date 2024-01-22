using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Question:
Write a program in C# to count total number of duplicate elements in an array

Approach:
using foreach method to run a for each element in the array
 */



namespace Array_Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9 };
            foreach (int i in arr)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == i)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine($"{i} is repeated {count}");
                }
            }
            Console.ReadLine();
        }
    }
}
