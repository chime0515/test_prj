using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class patientBasedData : IComparable<patientBasedData>
    {
        public string ToWriteTitle()
        {
            string result = "ID" + "\t" +
                "Birthday" + "\t" +
                "Gender" + "\t" +
                "FirstDate" + "\t" +
                "AgeOfDiagnosis" + "\t" +
                "YearOfDiagnosis" + "\t" +
                "AdmissionCount" + "\t" +
                "AdmissionDaySum" + "\t" +
                "Expense" + "\t" +
                "Death" + "\t" +
                "DeathDate" + "\t" +
                "TimeToDeath";
            return result;
        }
        public string ToWriteLine()
        {
            string result =
                ID + "\t" +
                Birthday + "\t" +
                Gender + "\t" +
                _FirstDate + "\t" +
                AgeOfDiagnosis.ToString("F1") + "\t" +
                YearOfDiagnosis + "\t" +
                AdmissionCount + "\t" +
                AdmissionDaySum + "\t" +
                Expense.ToString("F1") + "\t" +
                (Death ? 1 : 0) + "\t" +
                (Death ? DeathDate : "") + "\t" +
                (Death ? TimeToDeath.ToString("F1") : "");
            if (comobility_count > 0)
                for (int i = 0; i < comobility.Length; i++) result += "\t" + comobility[i];
            if (operation_count > 0)
                for (int i = 0; i < operation.Length; i++) result += "\t" + operation[i];
            if (comobility_count > 0)
                for (int i = 0; i < comobility.Length; i++) result += "\t" + (comobility[i] == 0 ? "" : get_year_to_comobility(i).ToString("F1"));//get_year_to_comobility(i).ToString("F1")    comobility_FirstDate[i]
            if (operation_count > 0)
                for (int i = 0; i < operation.Length; i++) result += "\t" + (operation[i] == 0 ? "" : get_year_to_operation(i).ToString("F1"));//get_year_to_operation(i).ToString("F1")   operation_FirstDate[i]
            return result;
        }
        public override string ToString()
        {
            return "ID: " + ID + " \tBirthday: " + Birthday + "\r\n" +
                " \tFirstDate: " + _FirstDate + " \tAge: " + AgeOfDiagnosis.ToString("F1");
        }

        //比較用
        public int CompareTo(patientBasedData other)
        {
            return (ID + Birthday).CompareTo(other.ID + other.Birthday);
        }

        public patientBasedData()//空
        {
        }
        public patientBasedData(string _ID, string _Birthday)//比較用
        {
            ID = _ID;
            Birthday = _Birthday;
        }
        public patientBasedData(string _ID, string _Birthday, string _Gender, string _ApplyDate, int Comobility_Count, int Operation_Count)
        {
            ID = _ID;
            Birthday = _Birthday;
            Gender = _Gender;
            _FirstDate = "";
            FirstDate = _ApplyDate;
            AdmissionCount = 0; AdmissionDaySum = 0; Expense = 0;
            DeathDate = "";
            Death = false;
            comobility_count = Comobility_Count;
            if (comobility_count > 0)
            {
                comobility = new int[comobility_count];
                comobility_FirstDate = new string[comobility_count];
                for (int i = 0; i < comobility_count; i++) comobility_FirstDate[i] = "";
            }
            operation_count = Operation_Count;
            if (operation_count > 0)
            {
                operation = new int[operation_count];
                operation_FirstDate = new string[operation_count];
                for (int i = 0; i < operation_count; i++) operation_FirstDate[i] = "";
            }
        }
        public string ID;
        public string Birthday;
        public string ID_Birthday { get { return ID + Birthday; } }
        public string Gender;
        private string _FirstDate;
        public string FirstDate
        {
            get { return _FirstDate; }
            set
            {
                if (FirstDate == "" || Convert.ToDateTime(value) < Convert.ToDateTime(_FirstDate))
                {
                    _FirstDate = value;
                    AgeOfDiagnosis = getAge(value);
                    YearOfDiagnosis = value.Substring(0, 4);
                }
            }
        }
        //
        public Double AgeOfDiagnosis { get; private set; }
        public string YearOfDiagnosis { get; private set; }
        //
        public int AdmissionCount;
        public int AdmissionDaySum;
        public int Expense;
        private string _DeathDate;
        public string DeathDate
        {
            get { return _DeathDate; }
            set
            {
                AgeOfDeath = getAge(value);
                _DeathDate = value;
            }
        }
        public Double AgeOfDeath { get; private set; }
        public bool Death;
        public double TimeToDeath
        {
            get
            {
                if (Death)
                {
                    try
                    {
                        int dayDif = Convert.ToDateTime(DeathDate).Date.Subtract(Convert.ToDateTime(_FirstDate).Date).Days;
                        return (double)dayDif / 365;
                    }
                    catch
                    {
                        return 0;
                    }
                }
                return 0;
            }
        }
        //
        public int comobility_count;
        public int[] comobility;
        public string[] comobility_FirstDate;
        public void set_comobility_FirstDate(string date, int index)
        {
            if (comobility_FirstDate[index] == "" || Convert.ToDateTime(date) < Convert.ToDateTime(comobility_FirstDate[index]))
            {
                comobility_FirstDate[index] = date;
            }
        }
        public double get_year_to_comobility(int index)
        {

            string date = comobility_FirstDate[index];
            if (date == "") return 0;

            int dayDif = Convert.ToDateTime(date).Date.Subtract(Convert.ToDateTime(_FirstDate).Date).Days;
            return (double)dayDif / 365;
        }
        //
        public int operation_count;
        public int[] operation;
        public string[] operation_FirstDate;
        public void set_operation_FirstDate(string date, int index)
        {
            if (operation_FirstDate[index] == "" || Convert.ToDateTime(date) < Convert.ToDateTime(operation_FirstDate[index]))
            {
                operation_FirstDate[index] = date;
            }
        }
        public double get_year_to_operation(int index)
        {

            string date = operation_FirstDate[index];
            if (date == "") return 0;

            int dayDif = Convert.ToDateTime(date).Date.Subtract(Convert.ToDateTime(_FirstDate).Date).Days;
            return (double)dayDif / 365;
        }
       //
        private double getAge(string date)
        {
            if (date == "") return 0;
            int dayDif = Convert.ToDateTime(date).Date.Subtract(Convert.ToDateTime(Birthday).Date).Days;
            return (double)dayDif / 365;
        }
    }
}
