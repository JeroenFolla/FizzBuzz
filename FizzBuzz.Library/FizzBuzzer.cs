using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
            return input.ToString();
        }
    }
}
