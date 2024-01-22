using System;

namespace Array_Problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 3, 7, 5 };
            //int[] arr = { 1, 2, 3, 3, 4, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Unique Values Below");
            for (int i = 0; i < arr.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.ReadLine();
        }
    }
}
