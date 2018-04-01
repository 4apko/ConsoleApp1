using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class TaskUtills
    {
        public static bool IsCorrectNum(string s) => Int32.TryParse(s, out int a) && a > 0;

    }
}
