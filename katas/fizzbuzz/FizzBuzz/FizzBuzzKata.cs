using System;

namespace FizzBuzz
{
    public class FizzBuzzKata
    {
        public static void Main(string[] args)
        {
            var fizzBuzzKata = new FizzBuzzKata();
        }

        public FizzBuzzKata()
        {
            var fizzBuzz = new FizzBuzz();

            Console.WriteLine("Starting Number: ");
            var startNum = GetNumericInput();
            Console.WriteLine("Ending Number: ");
            var endNum = GetNumericInput();

            Console.WriteLine("\r\nFizzBuzz Sequence: ");
            for (var i = startNum; i <= endNum; i++)
            {
                Console.WriteLine(fizzBuzz.Answer(i));
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
    }
}
