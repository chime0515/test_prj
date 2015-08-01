using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static class tool
    {
        public static string dateFormat(string input)
        {
            string result = "";
            try
            {
                result = DateTime.Parse(input.Substring(0, 4) + "-" + input.Substring(4, 2) + "-" + input.Substring(6, 2)).ToString("yyyy-MM-dd");
            }
            catch { }
            return result;
        }
        public static void ClearLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Console.CursorTop > 0)
                {
                    Console.WriteLine("".PadRight(Console.WindowWidth, ' '));
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (Console.CursorTop > 0)
                {
                    Console.CursorTop--;
                }
            }
        }
        public static void BackLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (Console.CursorTop > 0)
                {
                    Console.CursorTop--;
                }
            }
        }

    }
}
