using System;

namespace FizzBuzz
{
    public class FizzBuzzKata
    {
        public static void Main(string[] args)
        {
            FizzBuzzKata fizzBuzz = new FizzBuzzKata();
        }

        public FizzBuzzKata()
        {
            Console.WriteLine("Starting Number: ");
            var startNum = GetNumericInput();
            Console.WriteLine("Ending Number: ");
            var endNum = GetNumericInput();

            Console.WriteLine("\r\nFizzBuzz Sequence: ");
            for (var i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(Answer(i));
            }
        }

        private int GetNumericInput()
        {
            string input = null;
            while (input == null)
            {
                Console.WriteLine("Enter numeric value...");
                input = Console.ReadLine();
            }

            return Int32.Parse(input);
        }

        private string Answer(int num)
        {
            if (num%3 == 0 && num%5 == 0) return "fizzbuzz";
            if (num%3 == 0) return "fizz";
            if (num%5 == 0) return "buzz";

            return num.ToString();
        }
    }
}
