using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NHIRD_rawHV
    {
        public override string ToString()
        {
            string result = "";
            result += " year = " + year + ",";
            result += " filename = " + filename + "\r\n";
            result += " ID = " + ID + ",";
            result += " DISE_CODE = " + DISE_CODE + ",";
            result += " HV_TYPE = " + HV_TYPE + "\r\n";
            result += " ID_BIRTHDAY = " + ID_BIRTHDAY + ",";
            result += " ID_SEX = " + ID_SEX + ",";
            result += " APPL_DATE = " + APPL_DATE + "\r\n";
            result += " HOSP_ID = " + HOSP_ID + ",";
            result += " PRSN_ID = " + PRSN_ID + "\r\n";
            result += " DEATH_MARK = " + DEATH_MARK + ",";
            result += " DEATH_DATE = " + DEATH_DATE;
            return result;
        }
        public string ToWriterTitle()
        {
            string result = "";
            result += "year\t";
            result += "filename\t";
            result += "ID\t";
            result += "DISE_CODE\t";
            result += "HV_TYPE\t";
            result += "ID_BIRTHDAY\t";
            result += "ID_SEX\t";
            result += "APPL_DATE\t";
            result += "HOSP_ID\t";
            result += "PRSN_ID\t";
            result += "DEATH_MARK\t";
            result += "DEATH_DATE";
            return result;
        }
        public string ToWriter()
        {
            string result = "";
            result += year + "\t";
            result += filename + "\t";
            result += ID + "\t";
            result += DISE_CODE + "\t";
            result += HV_TYPE + "\t";
            result += tool.dateFormat(ID_BIRTHDAY) + "\t";
            result += ID_SEX + "\t";
            result += tool.dateFormat(APPL_DATE) + "\t";
            result += HOSP_ID + "\t";
            result += PRSN_ID + "\t";
            result += DEATH_MARK + "\t";
            result += tool.dateFormat(DEATH_DATE);
            return result;
        }
        public bool valid = false;
        public int year;
        public string filename;
        public string ID;
        public string DISE_CODE;
        public string HV_TYPE;
        public string ID_BIRTHDAY;
        public string ID_SEX;
        public string APPL_DATE;
        public string HOSP_ID;
        public string PRSN_ID;
        public string DEATH_MARK;
        public string DEATH_DATE;
        public NHIRD_rawHV(bool _valid)
        {
            valid = _valid;
        }
        public NHIRD_rawHV()
        {
        }
    }
}
