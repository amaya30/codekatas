using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            return IsEmpty(numbers) ? 0 : GetSum(numbers);
        }

        private bool IsEmpty(string numbers)
        {
            return numbers.Length < 1;
        }

        private int GetSum(string numbers)
        {
            var delimiter = GetPossibleDelimiters();
            if (ContainsAny(numbers, delimiter))
                return numbers.Split(delimiter.ToCharArray()).Sum(n => Convert.ToInt32(n));

            return Convert.ToInt32(numbers);
        }

        private string GetPossibleDelimiters()
        {
            return ",\n";
        }

        private bool ContainsAny(string numbers, string delimiter)
        {
            return delimiter.ToCharArray().Any(numbers.Contains);
        }
    }
}
