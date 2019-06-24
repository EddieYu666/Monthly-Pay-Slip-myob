using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPaySlip_FeiYu.DataModels
{
    public class TaxRates
    {
        AnnualSalary _AnnualSalary;
        public TaxRates(AnnualSalary income) {
            _AnnualSalary = income;
        }

        public int GetMonthlyIncomeTax()
        {
            decimal incomeTax = GetIncomeTax();
            int monthlyIncomeTax = (int)(incomeTax / 12 * 100 + 50) / 100;

            return monthlyIncomeTax;
        }

        public decimal GetIncomeTax()
        {
            decimal tax = 0;

            tax += _AnnualSalary.GetAnnualTaxInBand(0, 18200) * 0;
            tax += _AnnualSalary.GetAnnualTaxInBand(18200, 37000) * 0.19m;
            tax += _AnnualSalary.GetAnnualTaxInBand(37000, 87000) * 0.325m;
            tax += _AnnualSalary.GetAnnualTaxInBand(87000, 180000) * 0.37m;
            tax += _AnnualSalary.GetAnnualTaxOverBand(180000) * 0.45m;

            return tax;
        }
    }
}
