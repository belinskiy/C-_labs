using System;

namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_number;
            int second_number;
            int result;

            Console.WriteLine("Enter first number: ");
            first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            second_number = Convert.ToInt32(Console.ReadLine());

            result = (int)Math.Pow((first_number * second_number),3);
            Console.WriteLine("Result is: " + result);
        }
    }
}

