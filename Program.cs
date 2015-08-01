using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace ConsoleApplication1
{
    class Program
    {
        static string dirOutPath = @"D:\G Drive\NHIRD ASTHMA LEUKEMIA\Result\";
        static string datapathCD = @"E:\重大傷病檔門診1997_2011(Lee)\";
        static string datapathDD = @"E:\所有住院(含重大傷病檔住院)1997_2011(Lee)\";
        static string datapathHV = @"E:\基本資料檔1997_2011 (Lee)";

        static void Main(string[] args)
        {
            Console.SetWindowSize(140, 30);
            Console.SetWindowPosition(5, 5);

            GetRawDataFromDD.UsingCode(@"D:\G Drive\NHIRD ASTHMA LEUKEMIA\ICD9.txt", @"D:\test files\", "*DD*", @"D:\test files\result\");
            
            List<patientBasedData> List_patient = new List<patientBasedData>();



            Console.WriteLine("Press x to exit");
            do { } while (Console.ReadKey(true).KeyChar != 'x');
        } 
        static List<string> ID_List = new List<string>();
        
        static void GetIDList(string Read_file_path)
        {
            ID_List.Clear();
            var sr = new StreamReader(Read_file_path);
            string title = sr.ReadLine();
            int index_ID = title.Split('\t').ToList().FindIndex(x => x.IndexOf("ID") >= 0);
            int index_Birthday = title.Split('\t').ToList().FindIndex(x => x.IndexOf("Birthday") >= 0);
            Console.WriteLine("index ID = {0}, index Birthday = {1}", index_ID, index_Birthday);
            int count = 0;
            while (sr.Peek() > -1)
            {
                string[] split = sr.ReadLine().Split('\t');
                string IDBirthday = split[index_ID] + split[index_Birthday];
                int index = ID_List.BinarySearch(IDBirthday);
                if (index < 0)
                {
                    ID_List.Insert((index * -1) - 1, IDBirthday);
                }
                //Console.WriteLine("#{0} ID_Birthday = {1}, index = {2}, List count = {3}", ++count, IDBirthday, index, ID_List.Count());
                //if(index > -1) Console.ReadKey(true);
            }
            sr.Close();
            Console.WriteLine("Total List Count {0}", ID_List.Count);
        }
       
    }




}
