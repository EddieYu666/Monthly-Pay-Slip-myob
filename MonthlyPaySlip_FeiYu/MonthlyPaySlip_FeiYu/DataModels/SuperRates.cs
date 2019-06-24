using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPaySlip_FeiYu.DataModels
{
    public class SuperRates
    {
        decimal _SuperRate;
        int _MonthlyIncome;

        public SuperRates(string superRate, int monthlyIncome)
        {
            _SuperRate = decimal.Parse(superRate.Remove(superRate.Length - 1));
            _MonthlyIncome = monthlyIncome;
        }

        public int GetSuper()
        {
            int result = 0;

            result = (int)(_MonthlyIncome * _SuperRate + 50) / 100;

            return result;
        }
    }
}
