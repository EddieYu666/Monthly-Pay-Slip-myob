using System;
using System.Collections.Generic;
using System.Text;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.DataReader
{
    public class DataRows
    {
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _AnnualSalary { get; set; }
        public string _SuperRate { get; set; }
        public PayPeriod _PayPeriod { get; set; }
    }
}
