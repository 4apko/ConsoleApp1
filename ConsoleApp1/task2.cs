using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Please enter the number!");
            var entered = Console.ReadLine();

            if (TaskUtills.IsCorrectNum(entered))
            {
                for (int i = 1; i <= Int32.Parse(entered); i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else
            {
                Console.WriteLine("Please enter correct number!");
            }
        }
    }
}
