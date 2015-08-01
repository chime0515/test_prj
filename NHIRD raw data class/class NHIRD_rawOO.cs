using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NHIRD_rawOO
    {
        public override string ToString()
        {
            string result = "";
            result += " year = " + year + ",";
            result += " filename = " + filename + ",";
            result += " FEE_YM = " + FEE_YM + ",";
            result += " HOSP_ID = " + HOSP_ID + "\r\n";
            result += " CASE_TYPE = " + CASE_TYPE + ",";
            result += " SEQ_NO = " + SEQ_NO + ",";
            result += " DRUG_NO = " + DRUG_NO;
            return result;
        }
        public string ToWriterTitle()
        {
            string result = "";
            result += "year\t";
            result += "filename\t";
            result += "FEE_YM\t";
            result += "HOSP_ID\t";
            result += "CASE_TYPE\t";
            result += "SEQ_NO \t";
            result += "DRUG_NO";
            return result;
        }
        public string ToWriter()
        {
            string result = "";
            result += year + "\t";
            result += filename + "\t";
            result += FEE_YM + "\t";
            result += HOSP_ID + "\t";
            result += CASE_TYPE + "\t";
            result += SEQ_NO + "\t";
            result += DRUG_NO;
            return result;
        }
        
        public bool valid = false;
        public int year;
        public string filename;
        public string FEE_YM;
        public string HOSP_ID;
        public string CASE_TYPE;
        public string SEQ_NO;
        public string DRUG_NO;

        public NHIRD_rawOO(bool _valid)
        {
            valid = _valid;
        }
        public NHIRD_rawOO()
        {
        }

    }
}
