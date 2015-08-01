using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    //載入標準格式的ICD9 List
    static class ICDList
    {
        public static void loadICDList(string codePath, ref List<string> ICDname, ref List<List<string>> ICDcodeToInclude, ref List<List<string>> ICDcodeToExclude)
        {
            //載入ICD codes
            StreamReader sr = new StreamReader(codePath);
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();

                ICDname.Add(line.Split('\t')[0]);
                ICDcodeToInclude.Add(new List<string>(line.Split('\t')[1].Split(',')));
                if (line.Split('\t').Length > 2)
                {
                    ICDcodeToExclude.Add(new List<string>(line.Split('\t')[2].Split(',')));
                }
                else
                {
                    ICDcodeToExclude.Add(new List<string>());
                }
            }
            for (int i = 0; i < ICDcodeToInclude.Count; i++)
            {
                // Console.Write("name:" + ICDname[i] + ", codes: ");
                for (int j = 0; j < ICDcodeToInclude[i].Count; j++)
                {
                    ICDcodeToInclude[i][j] = ICDcodeToInclude[i][j].Replace("_", " ");
                    // Console.Write(", " + ICDcode[i][j]);
                }
                // Console.Write(", exclude: ");
                for (int j = 0; j < ICDcodeToExclude[i].Count; j++)
                {
                    ICDcodeToExclude[i][j] = ICDcodeToExclude[i][j].Replace("_", " ");
                    // Console.Write(", " + ICDcodeToExclude[i][j]);
                }
                // Console.Write("\r\n");
            }
        }
        public static bool checkICD(string[] ICDs, List<List<string>> ICDcode, List<List<string>> ICDcodeToExclude)
        {
            bool result = false;
            foreach (string currentICD in ICDs)
            {
                for (int i = 0; i < ICDcode.Count; i++)
                {
                    for (int j = 0; j < ICDcode[i].Count; j++)
                    {
                        if (currentICD.Substring(0, ICDcode[i][j].Length) == ICDcode[i][j])
                        {
                            result = true;
                            continue;
                        }
                    }
                    if (result) continue;
                }

                if (result)
                {
                    for (int i = 0; i < ICDcodeToExclude.Count; i++)
                    {
                        for (int j = 0; j < ICDcodeToExclude[i].Count; j++)
                        {
                            if (currentICD.Substring(0, ICDcode[i][j].Length) == ICDcode[i][j])
                            {
                                result = false;
                                continue;
                            }
                        }
                        if (!result) continue;
                    }
                }
                if (result) continue;
            }
            return result;
        }
    }
}
