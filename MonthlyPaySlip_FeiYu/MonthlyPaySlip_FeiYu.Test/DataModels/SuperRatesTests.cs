using System;
using Xunit;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataModels
{
    public class SuperRatesTests
    {
        [Fact]
        public void GetSuper_RoundDown()
        {
            var target = new SuperRates("9%", 5004);
            int result = target.GetSuper();

            Assert.Equal(450, result);
        }

        [Fact]
        public void GetSuper_RoundUp()
        {
            var target = new SuperRates("10%", 6199);
            int result = target.GetSuper();

            Assert.Equal(620, result);
        }

        [Fact]
        public void GetSuper_Rate9_7()
        {
            var target = new SuperRates("9.7%", 3778);
            int result = target.GetSuper();

            Assert.Equal(366, result);
        }
    }
}
