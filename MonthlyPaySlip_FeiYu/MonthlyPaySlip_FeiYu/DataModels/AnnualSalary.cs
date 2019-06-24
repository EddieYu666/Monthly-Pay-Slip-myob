using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPaySlip_FeiYu.DataModels
{
    public class AnnualSalary
    {
        decimal _AnnualSalaryBeforeTax;

        public AnnualSalary(decimal annualSalary)
        {
            _AnnualSalaryBeforeTax = annualSalary;
        }

        public int AnnualSalaryBeforeTax
        {
            get
            {
                return (int)_AnnualSalaryBeforeTax;
            }
        }

        public int GetMonthlyIncome()
        {
            int result = 0;

            result = (int)(_AnnualSalaryBeforeTax / 12 * 100 + 50) / 100;

            return result;
        }

        public decimal GetAnnualTaxInBand(int bottomOfBand, int topOfBand)
        {
            decimal taxInBand = 0;

            if (bottomOfBand < _AnnualSalaryBeforeTax)
            {
                taxInBand = _AnnualSalaryBeforeTax < topOfBand ? _AnnualSalaryBeforeTax - bottomOfBand : topOfBand - bottomOfBand;
            }

            return taxInBand;
        }

        public decimal GetAnnualTaxOverBand(int bottomOfBand)
        {
            decimal taxInBand = 0;

            if (bottomOfBand < _AnnualSalaryBeforeTax) taxInBand = _AnnualSalaryBeforeTax - bottomOfBand;

            return taxInBand;
        }
    }
}
