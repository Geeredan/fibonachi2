using System;

namespace fibonachi2
{
    // Main program class where execution begins
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Fibonacci Numbers ---");

            Console.Write("Enter the Fibonacci number index (n): ");
            int number = int.Parse(Console.ReadLine());

            // Call the static method from the separate Fibonacci class
            int result = Fibonacci.GetFibonacci(number);

            Console.WriteLine($"Output value: {result}");

            Console.ReadLine();
        }
    }

    // Separate static class
    public static class Fibonacci
    {
        // Recursive method to calculate the Fibonacci number
        public static int GetFibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Recursive step: each subsequent number is the sum of the two preceding ones
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}