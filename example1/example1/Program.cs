using System;

namespace example1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter a value for a:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b:");
            b = Int32.Parse(Console.ReadLine());    

            Console.WriteLine($"Adding {a} + {b} equals {AddNumbers(a, b)}");
            Console.WriteLine($"Substring {a} - {b} equals {SubsNumbers(a, b)}");
            Console.WriteLine($"Multiply {a} * {b} equals {Multiply(a, b)}");
            

        }
        //Funtion to evaluate two numbers
        // Change the funtion now to returns a adding

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        //Funtion to evaluate two numbers
        // Change the funtion now to returns a multiply
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
         // Add new funtion  to returns a subtraction
        //Funtion to evaluate two numbers
        // Change the funtion now to returns a subtraction
        public static int SubsNumbers(int a, int b)
        {
            return a -  b;
        }

       
    }
}
