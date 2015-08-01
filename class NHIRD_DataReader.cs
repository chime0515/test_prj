using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    static class NHIRD_DataReader
    {
        public static string getFilenamefromPath(string path)
        {
            return path.Split('\\')[path.Split('\\').Length - 1].Split('.')[0];
        }


        public static int getYearFromfilename(string filename)
        {
            int year=0;
            string NumericPart="";
            foreach (char c in filename)
            {
                if (char.IsDigit(c))
                {
                    NumericPart+=c;
                }
            }
            if (!Int32.TryParse(NumericPart.Substring(0, 4), out year))  //檢查年份是否傳換成功
            {
                return -1;
            }
            return year;
        }
        public static NHIRD_rawHV Read_HV(string line, string filename, int year)
        {         
            var result = new NHIRD_rawHV(true);

            if (year >= 1996 && year <= 2004)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.ID = line.Substring(0, 32);
                    result.DISE_CODE = line.Substring(32, 5);
                    result.HV_TYPE = line.Substring(37, 2);
                    result.ID_BIRTHDAY = line.Substring(39, 8);
                    result.ID_SEX = line.Substring(47, 1);
                    result.APPL_DATE = line.Substring(48, 8);
                    result.HOSP_ID = line.Substring(57, 34);
                    result.PRSN_ID = line.Substring(91, 32);
                    result.DEATH_MARK = line.Substring(292, 1) == "M" ? "1" : "";
                    result.DEATH_DATE = result.DEATH_MARK == "1" ? line.Substring(293, 8) : "";
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2005 && year <= 2009)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.ID = line.Substring(0, 32);
                    result.DISE_CODE = line.Substring(32, 5);
                    result.HV_TYPE = line.Substring(37, 2);
                    result.ID_BIRTHDAY = line.Substring(39, 8);
                    result.ID_SEX = line.Substring(47, 1);
                    result.APPL_DATE = line.Substring(48, 8);
                    result.HOSP_ID = line.Substring(57, 34);
                    result.DEATH_MARK = line.Substring(292, 1) == "Y" ? "1" : "";
                    result.DEATH_DATE = result.DEATH_MARK == "1" ? line.Substring(293, 8) : "";
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2010 && year <= 2011)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.ID = line.Substring(0, 32);
                    result.DISE_CODE = line.Substring(32, 5);
                    result.HV_TYPE = line.Substring(37, 2);
                    result.ID_BIRTHDAY = line.Substring(39, 8);
                    result.ID_SEX = line.Substring(47, 1);
                    result.APPL_DATE = line.Substring(48, 8);
                    result.HOSP_ID = line.Substring(57, 34);
                    result.PRSN_ID = line.Substring(91, 32);
                    result.DEATH_MARK = line.Substring(292, 1) == "Y" ? "1" : "";
                    result.DEATH_DATE = result.DEATH_MARK == "1" ? line.Substring(293, 8) : "";
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }

            return result;
        }
        public static NHIRD_rawDD Read_DD(string line, string filename, int year)
        {
           
            var result = new NHIRD_rawDD(true);
            if (year >= 1996 && year <= 2003)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM=line.Substring(0,6 );
                    result.HOSP_ID=line.Substring(7,34 );
                    result.CASE_TYPE=line.Substring(49,1 );
                    result.SEQ_NO=line.Substring(50,6 );
                    result.ID=line.Substring(56,32 );
                    result.ID_BIRTHDAY=line.Substring(88,8 );
                    result.GAVE_KIND=line.Substring(96,1 );
                    result.FUNC_TYPE=line.Substring(101,2 );
                    result.IN_DATE=line.Substring(103,8 );
                    result.OUT_DATE=line.Substring(111,8 );
                    result.E_BED_DAY=line.Substring(135,3 );
                    result.S_BED_DAY=line.Substring(138,3 );
                    result.PRSN_ID=line.Substring(141,32 );
                    result.TRAN_CODE=line.Substring(188,1 );
                    result.ICD9CM_CODE=
                        new string[]
                        {
                            line.Substring( 189,5),
                            line.Substring( 194,5),
                            line.Substring( 199,5),
                            line.Substring( 204,5),
                            line.Substring( 209,5)
                        };
                    result.ICD_OP_CODE=
                        new string[]
                        {
                            line.Substring(214,4),
                            line.Substring(218,4),
                            line.Substring(222,4),
                            line.Substring(226,4),
                            line.Substring(230,4)
                        };
                    result.MED_AMT=line.Substring(360, 8);
                    result.PART_MARK=line.Substring(488,3 );
                    result.ID_SEX=line.Substring(491, 1);
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else  if (year >= 2004 && year <= 2006)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.CASE_TYPE = line.Substring(49, 1);
                    result.SEQ_NO = line.Substring(50, 6);
                    result.ID = line.Substring(56, 32);
                    result.ID_BIRTHDAY = line.Substring(88, 8);
                    result.GAVE_KIND = line.Substring(96, 1);
                    result.FUNC_TYPE = line.Substring(102, 2);
                    result.IN_DATE = line.Substring(104, 8);
                    result.OUT_DATE = line.Substring(112, 8);
                    result.E_BED_DAY = line.Substring(136, 3);
                    result.S_BED_DAY = line.Substring(139, 3);
                    result.PRSN_ID = line.Substring(142, 32);
                    result.TRAN_CODE = line.Substring(189, 1);
                    result.ICD9CM_CODE =
                        new string[]
                        {
                            line.Substring( 190,5),
                            line.Substring( 195,5),
                            line.Substring( 100,5),
                            line.Substring( 205,5),
                            line.Substring( 210,5)
                        };
                    result.ICD_OP_CODE =
                        new string[]
                        {
                            line.Substring( 215,4),
                            line.Substring( 219,4),
                            line.Substring( 223,4),
                            line.Substring( 227,4),
                            line.Substring( 231,4)
                        };
                    result.MED_AMT = line.Substring(361, 8);
                    result.PART_MARK = line.Substring(489, 3);
                    result.ID_SEX = line.Substring(492, 1);
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else  if (year >= 2006 && year <= 2011)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.CASE_TYPE = line.Substring(49, 1);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.ID = line.Substring(57, 32);
                    result.ID_BIRTHDAY = line.Substring(89, 8);
                    result.GAVE_KIND = line.Substring(97, 1);
                    result.FUNC_TYPE = line.Substring(103, 2);
                    result.IN_DATE = line.Substring(105, 8);
                    result.OUT_DATE = line.Substring(113, 8);
                    result.E_BED_DAY = line.Substring(138, 3);
                    result.S_BED_DAY = line.Substring(140, 3);
                    result.PRSN_ID = line.Substring(143, 32);
                    result.TRAN_CODE = line.Substring(190, 1);
                    result.ICD9CM_CODE =
                        new string[]
                        {
                            line.Substring( 191,5),
                            line.Substring( 196,5),
                            line.Substring( 101,5),
                            line.Substring( 206,5),
                            line.Substring( 211,5)
                        };
                    result.ICD_OP_CODE =
                        new string[]
                        {
                            line.Substring( 216,4),
                            line.Substring( 220,4),
                            line.Substring( 224,4),
                            line.Substring( 228,4),
                            line.Substring( 232,4)
                        };
                    result.MED_AMT = line.Substring(362, 8);
                    result.PART_MARK = line.Substring(490, 3);
                    result.ID_SEX = line.Substring(493, 1);
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            return result;
        }
        public static NHIRD_rawCD Read_CD(string line, string filename, int year)
        {
          
            var result = new NHIRD_rawCD(true);
            if (year >= 1996 && year <= 2003)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM=line.Substring(0,6);
                    result.HOSP_ID=line.Substring(7,34);
                    result.CASE_TYPE=line.Substring(49,2);
                    result.SEQ_NO=line.Substring(51,2);
                    result.FUNC_TYPE=line.Substring(65,2);
                    result.FUNC_DATE=line.Substring(67,8);
                    result.ID_BIRTHDAY=line.Substring(83,8);
                    result.ID=line.Substring(91,32);
                    result.GAVE_KIND=line.Substring(126,1);
                    result.PART_NO=line.Substring(127,3);
                    result.ACODE_ICD9=
                    new string[]
                        {
                            line.Substring(130,5),
                            line.Substring(135,5),
                            line.Substring(140,5)
                        };
                    result.ICD_OP_CODE=line.Substring(145,4);
                    result.PRSN_ID=line.Substring(152,32);
                    result.T_AMT=line.Substring(274,8);
                    result.ID_SEX=line.Substring(298,1);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2004 && year <= 2009)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.CASE_TYPE = line.Substring(49, 2);
                    result.SEQ_NO = line.Substring(51, 2);
                    result.FUNC_TYPE = line.Substring(65, 2);
                    result.FUNC_DATE = line.Substring(67, 8);
                    result.ID_BIRTHDAY = line.Substring(83, 8);
                    result.ID = line.Substring(91, 32);
                    result.GAVE_KIND = line.Substring(127, 1);
                    result.PART_NO = line.Substring(128, 3);
                    result.ACODE_ICD9 =
                    new string[]
                        {
                            line.Substring(131,5),
                            line.Substring(136,5),
                            line.Substring(141,5)
                        };
                    result.ICD_OP_CODE = line.Substring(146, 4);
                    result.PRSN_ID = line.Substring(153, 32);
                    result.T_AMT = line.Substring(275, 8);
                    result.ID_SEX = line.Substring(299, 1);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2010)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.CASE_TYPE = line.Substring(49, 2);
                    result.SEQ_NO = line.Substring(51, 2);
                    result.FUNC_TYPE = line.Substring(65, 2);
                    result.FUNC_DATE = line.Substring(67, 8);
                    result.ID_BIRTHDAY = line.Substring(83, 8);
                    result.ID = line.Substring(91, 32);
                    result.GAVE_KIND = line.Substring(127, 1);
                    result.PART_NO = line.Substring(128, 3);
                    result.ACODE_ICD9 =
                    new string[]
                        {
                            line.Substring(131,5),
                            line.Substring(146,5),
                            line.Substring(152,5)
                        };
                    result.ICD_OP_CODE = line.Substring(176, 4);
                    result.PRSN_ID = line.Substring(194, 32);
                    result.T_AMT = line.Substring(316, 8);
                    result.ID_SEX = line.Substring(340, 1);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            return result;
        }
        public static NHIRD_rawOO Read_OO(string line, string filename, int year)
        {
           
            var result = new NHIRD_rawOO(true);
            if (year >= 1996 && year <= 2006)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.DRUG_NO = line.Substring(58, 12);
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2007 && year <= 2011)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.DRUG_NO = line.Substring(58, 12);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2012)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.DRUG_NO = line.Substring(58, 12);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            return result;
        }
        public static NHIRD_rawDO Read_DO(string line, string filename, int year)
        {
          
            var result = new NHIRD_rawDO(true);
            if (year >= 1996 && year <= 2006)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(50, 6);
                    result.ORDER_CODE = line.Substring(62, 12);
                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2007 && year <= 2009)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.ORDER_CODE = line.Substring(63, 12);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2010 && year <= 2011)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(51, 6);
                    result.ORDER_CODE = line.Substring(58, 12);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            else if (year >= 2012)
            {
                try
                {
                    result.year = year;
                    result.filename = filename;
                    result.FEE_YM = line.Substring(0, 6);
                    result.HOSP_ID = line.Substring(7, 34);
                    result.SEQ_NO = line.Substring(50, 6);
                    result.ORDER_CODE = line.Substring(62, 12);

                    result.valid = true;
                }
                catch
                {
                    result.valid = false;
                }
            }
            return result;
        }
    }

}
