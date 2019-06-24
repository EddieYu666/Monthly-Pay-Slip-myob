using System;
using Xunit;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataModels
{
    public class TaxRatesTests
    {
        [Fact]
        public void GetMonthlyIncomeTax_RoundDown()
        {
            var target = new TaxRates(new AnnualSalary(120000m));
            decimal result = target.GetMonthlyIncomeTax();

            Assert.Equal(2669, result);
        }

        [Fact]
        public void GetMonthlyIncomeTax_RoundUp()
        {
            var target = new TaxRates(new AnnualSalary(60050m));
            decimal result = target.GetMonthlyIncomeTax();

            Assert.Equal(922, result);
        }

        [Fact]
        public void GetIncomeTaxTest_lessThan18200()
        {
            var target = new TaxRates(new AnnualSalary(10000));
            decimal result = target.GetIncomeTax();

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetIncomeTaxTest_Between18201and37000()
        {
            var target = new TaxRates(new AnnualSalary(23001));
            decimal result = target.GetIncomeTax();

            Assert.Equal(912.19m, result);
        }

        [Fact]
        public void GetIncomeTaxTest_Between37001and87000()
        {
            var target = new TaxRates(new AnnualSalary(60050));
            decimal result = target.GetIncomeTax();

            Assert.Equal(11063.25m, result);
        }

        [Fact]
        public void GetIncomeTaxTest_Between87001and180000()
        {
            var target = new TaxRates(new AnnualSalary(140000));
            decimal result = target.GetIncomeTax();

            Assert.Equal(39432m, result);
        }

        [Fact]
        public void GetIncomeTaxTest_Over180001()
        {
            var target = new TaxRates(new AnnualSalary(240050));
            decimal result = target.GetIncomeTax();

            Assert.Equal(81254.5m, result);
        }
    }
}
