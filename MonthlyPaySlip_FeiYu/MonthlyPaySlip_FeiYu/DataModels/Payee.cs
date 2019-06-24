using System;
using System.Collections.Generic;
using System.Text;

namespace MonthlyPaySlip_FeiYu.DataModels
{
    public class Payee
    {
        public Payee(string firstName, string lastName, string annualSalary, string superRate, PayPeriod payPeriod)
        {
            _FirstName = firstName;
            _LastName = lastName;
            _AnnualSalary = new AnnualSalary(decimal.Parse(annualSalary));
            _SuperRates = new SuperRates(superRate, _AnnualSalary.GetMonthlyIncome());
            _TaxRates = new TaxRates(_AnnualSalary);
            _PayPeriod = payPeriod;
        }

        AnnualSalary _AnnualSalary { get; set; }
        SuperRates _SuperRates { get; set; }
        TaxRates _TaxRates { get; set; }
        PayPeriod _PayPeriod { get; set; }

        string _FirstName { get; set; }
        string _LastName { get; set; }

        public string PaySlip
        {
            get
            {
                return PaySlip_FullName + "," + PaySlip_PayPeriod + "," + PaySlip_GrossIncome + "," + PaySlip_IncomeTax + "," + PaySlip_NetIncome + "," + PaySlip_Super;
            }
        }

        public string PaySlip_FullName
        {
            get
            {
                return _FirstName + " " + _LastName;
            }
        }

        public string PaySlip_PayPeriod
        {
            get
            {
                return _PayPeriod.PayMonthPeriod;
            }
        }

        public string PaySlip_GrossIncome
        {
            get
            {
                return _AnnualSalary.GetMonthlyIncome().ToString();
            }
        }

        public string PaySlip_IncomeTax
        {
            get
            {
                return _TaxRates.GetMonthlyIncomeTax().ToString();
            }
        }

        public string PaySlip_NetIncome
        {
            get
            {
                return (_AnnualSalary.GetMonthlyIncome() - _TaxRates.GetMonthlyIncomeTax()).ToString();
            }
        }

        public string PaySlip_Super
        {
            get
            {
                return _SuperRates.GetSuper().ToString();
            }
        }

    }
}
