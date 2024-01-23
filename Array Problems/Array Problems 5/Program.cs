using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
5) Write a program to print below pattern.
********
*******
******
*****
****
***
**
*
*/

namespace Array_Problems_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = Convert.ToInt32(Console.ReadLine()); i != 0; i--)
            {
                string astrix = new string('*', i);
                Console.WriteLine(astrix);
            }
        }
    }
}
