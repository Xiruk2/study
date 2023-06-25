using System;

namespace FizzBuzzSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzz();
            Console.WriteLine(fizzBuzz.GetFizzBuzz());
            Console.ReadLine();
        }
    }

    public class FizzBuzz
    {
        private const int FizzNumber = 3;
        private const int BuzzNumber = 5;
        private const int FizzBuzzNumber = FizzNumber * BuzzNumber;
        private const string FizzMessage = "Fizz";
        private const string BuzzMessage = "Buzz";
        private const string FizzBuzzMessage = "FizzBuzz";

        private int MaxNumber;

        public FizzBuzz()
        {
            var convertInput = 0;
            
            if (!int.TryParse(Input(), out convertInput))
            {
                throw new FormatException();
            }

            MaxNumber = convertInput;
        }

        public FizzBuzz(int maxNumber)
        {
            MaxNumber = maxNumber;
        }

        public string GetFizzBuzz()
        {
            string result = string.Empty;
            for (var i = 1; i < MaxNumber + 1; i++)
            {
                result += Excute(i) + " ";
            }
            return result.TrimEnd();
        }

        private string Input()
        {
            Console.Write("FizzBuzzMax:");
            return Console.ReadLine();
        }

        private string Excute(int target)
        {
            if (target % FizzBuzzNumber == 0) return FizzBuzzMessage;
            if (target % FizzNumber == 0) return FizzMessage;
            if (target % BuzzNumber == 0) return BuzzMessage;
            return target.ToString();
        }
    }
}
