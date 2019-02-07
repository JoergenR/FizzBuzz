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
            int number = 100;

            for (int i = 1; i <= number; i++)
            {
                var result = FizzBuzz.GetFizzBuzz(i);

                Console.WriteLine(result);
            }
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
