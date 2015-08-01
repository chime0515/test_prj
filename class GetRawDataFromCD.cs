using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    static class GetRawDataFromCD
    {
        //標準格式icd code: name  \t icd(用逗號分開) \t icd_exclude(用逗號分開)
        public static void UsingCode(string codePath, string DataBaseDir, string SearchPattern, string OutPutPath)
        {
            List<string> ICDname = new List<string>();
            List<List<string>> ICDcodeToInclude = new List<List<string>>();
            List<List<string>> ICDcodeToExclude = new List<List<string>>();
            ICDList.loadICDList(codePath, ref ICDname, ref  ICDcodeToInclude, ref ICDcodeToExclude);

            StreamWriter sw = new StreamWriter(OutPutPath + "GetRawDataFromCD_UsingCode_"+DateTime.Now.ToString("yyyyMMdd_hhmm")+".txt");
            sw.WriteLine(new NHIRD_rawCD().ToWriterTitle());
            //開始過濾DD from DataBaseDir
            List<string> files = Directory.EnumerateFiles(DataBaseDir, SearchPattern).ToList();     

            View.currentFunction = "GetRawDataFromCD.UsingCode";
            View.totalFilecount = files.Count;

            foreach (string file in files)
            {
                View.currentFilePath = file;
                View.currentfilecount = ++View.currentfilecount;
             
                StreamReader sr = new StreamReader(file);
                string filename = NHIRD_DataReader.getFilenamefromPath(file);
                int year = NHIRD_DataReader.getYearFromfilename(filename);

                if (year < 0)
                {
                    continue;
                }
                while (sr.Peek() > -1)
                {
                    NHIRD_rawCD rawCD = NHIRD_DataReader.Read_CD(sr.ReadLine(), filename, year);
                    View.contentstr = rawCD.ToString();
                    View.AnalyzedCount++;
                    if (ICDList.checkICD(rawCD.ACODE_ICD9, ICDcodeToInclude, ICDcodeToExclude))
                    {
                        sw.WriteLine(rawCD.ToWriter());
                        View.Extractcount++;
                    }
                    View.show();
                }
            }
            sw.Close();
        }
    }
}
