using System;
using Xunit;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataModels
{
    public class PayPeriodTests
    {
        [Fact]
        public void PayMonthPeriod_ValidMonth_31Days()
        {
            var target = new PayPeriod(3);
            string result = target.PayMonthPeriod;

            Assert.Equal("01 March to 31 March", result);
        }

        [Fact]
        public void PayMonthPeriod_ValidMonth_30Days()
        {
            var target = new PayPeriod(9);
            string result = target.PayMonthPeriod;

            Assert.Equal("01 September to 30 September", result);
        }

        [Fact]
        public void PayMonthPeriod_ValidMonth_28Days()
        {
            var target = new PayPeriod(2);
            string result = target.PayMonthPeriod;

            Assert.Equal("01 February to 28 February", result);
        }
    }
}
