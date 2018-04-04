using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Please enter the number!");
            var entered = Console.ReadLine();
            if (TaskUtills.IsCorrectNum(entered))
            {
                int num = Int32.Parse(entered);

                for (int stage = 0; stage <= num; stage++)
                {
                    for (int i = 1; i <= stage; i++)
                    {
                        for (int spaces = num - i; spaces > 0; spaces--)
                        {
                            Console.Write(" ");
                        }
                        for (int stars = 1; stars < i; stars++)
                        {
                            Console.Write("*");
                        }
                        for (int stars = i; stars > 0; stars--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    
                }

            }
            else
            {
                Console.WriteLine("Not corrected number!");
            }
        }
    }
}
