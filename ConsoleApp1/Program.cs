using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Hello! Please enter size of rectangle. \na:");
            var first = Console.ReadLine();
            Console.WriteLine("b:");
            var second = Console.ReadLine();

            if (Int32.TryParse(first, out a) && Int32.TryParse(second, out b))
            {

                if (a > 0 && b > 0)
                {
                    Console.WriteLine("Square of rectangle is {0}", a * b);
                }
                else
                {
                    Console.WriteLine("Numbers must be greater than 0!");
                }
                
            }
            else
            {
                Console.WriteLine("Please enter correct numbers!");
            }

            Console.ReadLine();
        }
    }
}
