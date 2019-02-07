using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        /// <summary>Gets the fizz buzz.</summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
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
