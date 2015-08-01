using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NHIRD_rawCD
    {
        public override string ToString()
        {
            string result = "";
            result += " year = " + year + ",";
            result += " filename = " + filename + "\r\n";
            result += " FEE_YM = " + FEE_YM + ",";
            result += " HOSP_ID = " + HOSP_ID + ",";
            result += " CASE_TYPE = " + CASE_TYPE + "\r\n";
            result += " SEQ_NO = " + SEQ_NO + ",";
            result += " FUNC_TYPE = " + FUNC_TYPE + ",";
            result += " FUNC_DATE = " + FUNC_DATE + ",";
            result += " ID_BIRTHDAY = " + ID_BIRTHDAY + ",";
            result += " ID = " + ID + "\r\n";
            result += " GAVE_KIND = " + GAVE_KIND + ",";
            result += " PART_NO = " + PART_NO+ ",";
            result += " ACODE_ICD9[0] = " + ACODE_ICD9[0]+ ",";
            result += " ACODE_ICD9[1] = " + ACODE_ICD9[1]+ ",";
            result += " ACODE_ICD9[2] = " + ACODE_ICD9[2] + "\r\n";
            result += " ICD_OP_CODE = " + ICD_OP_CODE + ",";
            result += " PRSN_ID = " + PRSN_ID + ",";
            result += " T_AMT = " + T_AMT + ",";
            result += " ID_SEX = " + ID_SEX + ",";
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
            result += "SEQ_NO\t";
            result += "FUNC_TYPE\t";
            result += "FUNC_DATE\t";
            result += "ID_BIRTHDAY\t";
            result += "ID\t";
            result += "GAVE_KIND\t";
            result += "PART_NO\t";
            result += "ACODE_ICD9[0]\t";
            result += "ACODE_ICD9[1]\t";
            result += "ACODE_ICD9[2]\t";
            result += "ICD_OP_CODE\t";
            result += "PRSN_ID\t";
            result += "T_AMT\t";
            result += "ID_SEX";
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
            result += FUNC_TYPE + "\t";
            result += tool.dateFormat(FUNC_DATE) + "\t";
            result += tool.dateFormat(ID_BIRTHDAY) + "\t";
            result += ID + "\t";
            result += GAVE_KIND + "\t";
            result += PART_NO + "\t";
            result += ACODE_ICD9[0] + "\t";
            result += ACODE_ICD9[1] + "\t";
            result += ACODE_ICD9[2] + "\t";
            result += ICD_OP_CODE + "\t";
            result += PRSN_ID + "\t";
            result += T_AMT + "\t";
            result += ID_SEX;
            return result;
        }
        
        
        public bool valid = false;
        public int year;
        public string filename;



        public string FEE_YM;
        public string HOSP_ID;
        public string CASE_TYPE;
        public string SEQ_NO;
        public string FUNC_TYPE;
        public string FUNC_DATE;
        public string ID_BIRTHDAY;
        public string ID;
        public string GAVE_KIND;
        public string PART_NO;
        public string[] ACODE_ICD9;
        public string ICD_OP_CODE;
        public string PRSN_ID;
        public string T_AMT;
        public string ID_SEX;
        

        public NHIRD_rawCD(bool _valid)
        {
            valid = _valid;
        }
        public NHIRD_rawCD()
        {
        }

    }
}
