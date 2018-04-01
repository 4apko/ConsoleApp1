using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Hello! Please enter size of rectangle. \na:");
            var first = Console.ReadLine();
            Console.WriteLine("b:");
            var second = Console.ReadLine();

            if (TaskUtills.IsCorrectNum(first) && TaskUtills.IsCorrectNum(second))
            {
                Console.WriteLine("Square of rectangle is {0}", Int32.Parse(first) * Int32.Parse(second));
            }
            else
            {
                Console.WriteLine("Please enter correct numbers!");
            }

        }
    }
}
