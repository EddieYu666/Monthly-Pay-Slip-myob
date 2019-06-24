using System;
using Xunit;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataModels
{
    public class AnnualSalaryTests
    {
        [Fact]
        public void GetMonthlyIncome_RoundDown()
        {
            var target = new AnnualSalary(60050m);
            int result = target.GetMonthlyIncome();

            Assert.Equal(5004, result);
        }

        [Fact]
        public void GetMonthlyIncome_RoundUp()
        {
            var target = new AnnualSalary(80014m);
            int result = target.GetMonthlyIncome();

            Assert.Equal(6668, result);
        }

        [Fact]
        public void GetAnnualTaxInBand_UnderBand()
        {
            var target = new AnnualSalary(20000m);
            decimal result = target.GetAnnualTaxInBand(37000, 87000);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetAnnualTaxInBand_InBand()
        {
            var target = new AnnualSalary(50000m);
            decimal result = target.GetAnnualTaxInBand(37000, 87000);

            Assert.Equal(13000, result);
        }

        [Fact]
        public void GetAnnualTaxInBand_OverBand()
        {
            var target = new AnnualSalary(90000m);
            decimal result = target.GetAnnualTaxInBand(37000, 87000);

            Assert.Equal(50000, result);
        }

        [Fact]
        public void GetAnnualTaxOverBand_UnderBand()
        {
            var target = new AnnualSalary(90000m);
            decimal result = target.GetAnnualTaxOverBand(180000);

            Assert.Equal(0, result);
        }

        [Fact]
        public void GetAnnualTaxOverBand_InBand()
        {
            var target = new AnnualSalary(192223m);
            decimal result = target.GetAnnualTaxOverBand(180000);

            Assert.Equal(12223, result);
        }
    }
}
