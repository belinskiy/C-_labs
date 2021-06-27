using System;

namespace Lab_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int[] arr = new int[10]; // Initialize integer array
            for (int i = 0; i < 10; i++) // Fill an array with random integer numbers
            {
                arr[i] += rand.Next(100);
            }
            Array.Sort(arr); // Sorting the array in ascending order
            foreach(int value in arr)
            {
                Console.WriteLine(value); 
            }
        }
    }
}
