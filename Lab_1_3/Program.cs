using System;

namespace Lab_1_3
{
    class Program // 5 вариант задачи : Знайти усі елементи матриці, що більші за нуль, та знайти їх суму.
    {
        static void Main(string[] args)
        {
            int aboveZeroSum = 0;
            var rand = new Random();
            int row = 7, column = 5;
            int[,] arr = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = rand.Next(-10, 10);
                    Console.Write(arr[i, j] + "\t");
                    if (arr[i, j] > 0)
                    {
                        aboveZeroSum += arr[i, j];
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Sum of numbers in array that > 0 is: " + aboveZeroSum);
        }
    }
}
