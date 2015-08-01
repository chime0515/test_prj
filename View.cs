using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication1
{
    static class View
    {
        public static Stopwatch timer = new Stopwatch();
        //開始更新頻率計時器
        public static long lastrefresh = 0;
        public static int refrechfreq = 250;
        //共30行
        public static string currentFunction;  //0
        public static string currentFilePath;  //1
        public static int totalFilecount, currentfilecount = 0, Extractcount = 0, AnalyzedCount = 0;
        public static string[] content = new string[10];
        public static string contentstr
        {
            set
            {
                value = value.Replace("\r", "");
                string[] splt = value.Split('\n');
                for (int i = 0; i < 10; i++)
                {
                    if (i < splt.Length)
                    {
                        content[i] = splt[i];
                    }
                    else
                    {
                        content[i] = "";
                    }
                }
            }
        }
        public static string[] message = new string[5];
        public static string messagestr
        {
            set
            {
                value = value.Replace("\r", "");
                string[] splt = value.Split('\n');
                for (int i = 0; i < 5; i++)
                {
                    if (i < splt.Length)
                    {
                        content[i] = splt[i];
                    }
                    else
                    {
                        content[i] = "";
                    }
                }
            }
        }
        private static string bar;
        static View()
        {
            timer = Stopwatch.StartNew();
            bar = "".PadRight(Console.WindowWidth, '=');
        }

        public static void show(bool stat = false)
        {
            long currenttime = timer.ElapsedMilliseconds;
            if (stat || currenttime - lastrefresh > refrechfreq)
            {
                lastrefresh = currenttime;

                Console.Clear();
                Console.WriteLine("Current Function: {0}", currentFunction);
                Console.WriteLine("Current File Path: {0}", currentFilePath);
                Console.WriteLine("Progress {0}/{1}({2}%)", currentfilecount, totalFilecount, ((float)currentfilecount / totalFilecount * 100).ToString("F1"));
                Console.WriteLine(bar);
                foreach (string s in content)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(bar);
                foreach (string s in message)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine(bar);
                Console.WriteLine("Extracted: {0} / Analyzed: {1}  ({2}%)", Extractcount, AnalyzedCount, ((float)Extractcount / AnalyzedCount * 100).ToString("F3"));
            }
        }
    }
}
