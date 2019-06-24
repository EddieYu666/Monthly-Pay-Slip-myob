using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MonthlyPaySlip_FeiYu.DataModels
{
    public class PayPeriod
    {
        int _PayMonth;
        public PayPeriod (int Month)
        {
            _PayMonth = Month;
        }

        public string PayMonthPeriod
        {
            get
            {
                return StartDate.ToString("dd MMMM", new CultureInfo("en-us")) + " to " + EndDate.ToString("dd MMMM", new CultureInfo("en-us"));
            }
        }

        public DateTime StartDate
        {
            get
            {
                return new DateTime(DateTime.Now.Year, _PayMonth, 1);
            }
        }

        public DateTime EndDate
        {
            get
            {
                return StartDate.AddMonths(1).AddDays(-1);
            }
        }
    }
}
