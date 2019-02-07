using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // The program will run from 1 to endNumber.
            int endNumber = 100;

            // Prints out the result from 1 to endNumber.
            for (int i = 1; i <= endNumber; i++)
            {
                var result = FizzBuzz.GetFizzBuzz(i);

                Console.WriteLine(result);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
