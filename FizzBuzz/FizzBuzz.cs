using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        // GetFizzBuzz returns Fizz, Buzz, Fizz Buzz or the number depending on the number.
        public static string GetFizzBuzz(int number)
        {
            if ((number % 3 == 0) && (number % 5 == 0))
                return "Fizz Buzz";

            if (number % 3 == 0)
                return "Fizz";

            if (number % 5 == 0)
                return "Buzz";

            return number.ToString();
        }
    }
}
