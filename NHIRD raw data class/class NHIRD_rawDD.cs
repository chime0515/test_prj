using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NHIRD_rawDD
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
            result += " ID = " + ID + ",";
            result += " ID_BIRTHDAY = " + ID_BIRTHDAY + ",";
            result += " GAVE_KIND = " + GAVE_KIND + ",";
            result += " FUNC_TYPE = " + FUNC_TYPE + "\r\n";
            result += " IN_DATE = " + IN_DATE + ",";
            result += " OUT_DATE = " + OUT_DATE + ",";
            result += " E_BED_DAY = " + E_BED_DAY + ",";
            result += " S_BED_DAY = " + S_BED_DAY + ",";
            result += " PRSN_ID = " + PRSN_ID + ",";
            result += " TRAN_CODE = " + TRAN_CODE + "\r\n";
            result += " ICD9CM_CODE[0] = " + ICD9CM_CODE[0] + ",";
            result += " ICD9CM_CODE[1] = " + ICD9CM_CODE[1] + ",";
            result += " ICD9CM_CODE[2] = " + ICD9CM_CODE[2] + ",";
            result += " ICD9CM_CODE[3] = " + ICD9CM_CODE[3] + ",";
            result += " ICD9CM_CODE[4] = " + ICD9CM_CODE[4] + "\r\n";
            result += " ICD_OP_CODE[0] = " + ICD_OP_CODE[0] + ",";
            result += " ICD_OP_CODE[1] = " + ICD_OP_CODE[1] + ",";
            result += " ICD_OP_CODE[2] = " + ICD_OP_CODE[2] + ",";
            result += " ICD_OP_CODE[3] = " + ICD_OP_CODE[3] + ",";
            result += " ICD_OP_CODE[4] = " + ICD_OP_CODE[4] + "\r\n";
            result += " MED_AMT = " + MED_AMT + ",";
            result += " PART_MARK = " + PART_MARK + ",";
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
            result += "SEQ_NO \t";
            result += "ID\t";
            result += "ID_BIRTHDAY\t";
            result += "GAVE_KIND\t";
            result += "FUNC_TYPE\t";
            result += "IN_DATE\t";
            result += "OUT_DATE\t";
            result += "E_BED_DAY\t";
            result += "S_BED_DAY\t";
            result += "PRSN_ID\t";
            result += "TRAN_CODE\t";
            result += "ICD9CM_CODE[0]\t";
            result += "ICD9CM_CODE[1]\t";
            result += "ICD9CM_CODE[2]\t";
            result += "ICD9CM_CODE[3]\t";
            result += "ICD9CM_CODE[4]\t";
            result += "ICD_OP_CODE[0]\t";
            result += "ICD_OP_CODE[1]\t";
            result += "ICD_OP_CODE[2]\t";
            result += "ICD_OP_CODE[3]\t";
            result += "ICD_OP_CODE[4]\t";
            result += "MED_AMT\t";
            result += "PART_MARK\t";
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
            result += ID + "\t";
            result += ID_BIRTHDAY + "\t";
            result += GAVE_KIND + "\t";
            result += FUNC_TYPE + "\t";
            result += IN_DATE + "\t";
            result += OUT_DATE + "\t";
            result += E_BED_DAY + "\t";
            result += S_BED_DAY + "\t";
            result += PRSN_ID + "\t";
            result += TRAN_CODE + "\t";
            result += ICD9CM_CODE[0] + "\t";
            result += ICD9CM_CODE[1] + "\t";
            result += ICD9CM_CODE[2] + "\t";
            result += ICD9CM_CODE[3] + "\t";
            result += ICD9CM_CODE[4] + "\t";
            result += ICD_OP_CODE[0] + "\t";
            result += ICD_OP_CODE[1] + "\t";
            result += ICD_OP_CODE[2] + "\t";
            result += ICD_OP_CODE[3] + "\t";
            result += ICD_OP_CODE[4] + "\t";
            result += MED_AMT + "\t";
            result += PART_MARK + "\t";
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
        public string ID;
        public string ID_BIRTHDAY;
        public string GAVE_KIND;
        public string FUNC_TYPE;
        public string IN_DATE;
        public string OUT_DATE;
        public string E_BED_DAY;
        public string S_BED_DAY;
        public string PRSN_ID;
        public string TRAN_CODE;
        public string[] ICD9CM_CODE;
        public string[] ICD_OP_CODE;
        public string MED_AMT;
        public string PART_MARK;
        public string ID_SEX;


        public NHIRD_rawDD(bool _valid)
        {
            valid = _valid;
        }
        public NHIRD_rawDD()
        {
        }

    }
}
