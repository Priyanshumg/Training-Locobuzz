using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
Question:
Write a program in C# Sharp to count the frequency of each element of an array

*note:: 
So By frequency it means how many times a unique element has appeared
 */

namespace Array_Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] my_list = { 1, 2, 3, 4, 4, 5, 5, 6, 6, 7, 8, 9, 0};
            int count = 0;
            for (int i = 0; i < my_list.Length; i++)
            {
                bool isbool = false;
                for (int j = 0; j > i; j++)
                {
                    if (my_list[i] == j)
                    {
                        isbool = true;
                        break;
                    }
                }
                if (!isbool)
                {
                    
                }
            }
        }
    }
}
