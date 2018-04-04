using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Task6
    {
        static Dictionary<string, bool> fonts = new Dictionary<string, bool>();
        public static void Run()
        {
            
            StringBuilder sb = new StringBuilder();
            fillFonts();
            FontMethod(sb);


        }

        private static void FontMethod(StringBuilder sb)
        {
            Console.WriteLine("Параметры надписи: {0}", sb.Length.Equals(0) ? "None" : sb.ToString().TrimEnd(',', ' '));
            Console.WriteLine("Введите: \n 1: Bold \n 2: Italic\n 3: Underline");
            var entered = Console.ReadLine();
            if (TaskUtills.LessThanFour(entered))
            {
                switch (Int32.Parse(entered))
                {
                    case 1:
                        if (fonts["Bold"] == false)
                        {
                            fonts["Bold"] = true;
                            sb.Append("Bold, ");
                        }
                        else
                        {
                            fonts["Bold"] = false;
                            sb.Replace("Bold, ", "");
                        }
                        break;
                    case 2:
                        if (fonts["Italic"] == false)
                        {
                            fonts["Italic"] = true;
                            sb.Append("Italic, ");
                        }
                        else
                        {
                            fonts["Italic"] = false;
                            sb.Replace("Italic, ", "");
                        }
                        break;
                    case 3:
                        if (fonts["Underline"] == false)
                        {
                            fonts["Underline"] = true;
                            sb.Append("Underline, ");
                        }
                        else
                        {
                            fonts["Underline"] = false;
                            sb.Replace("Underline, ", "");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Введите число от 1 до 3!");
            }
            FontMethod(sb);
        }

        private static void fillFonts()
        {
            fonts.Add("Bold", false);
            fonts.Add("Italic", false);
            fonts.Add("Underline", false);
        }

    }
}
