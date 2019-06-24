using System;
using Xunit;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataModels
{
    public class PayeeTests
    {
        [Fact]
        public void Payee_CheckAll()
        {
            var target = new Payee("David", "Rudd", "60050", "9%", new PayPeriod(3));

            Assert.Equal("David Rudd", target.PaySlip_FullName);
            Assert.Equal("01 March to 31 March", target.PaySlip_PayPeriod);
            Assert.Equal("5004", target.PaySlip_GrossIncome);
            Assert.Equal("922", target.PaySlip_IncomeTax);
            Assert.Equal("4082", target.PaySlip_NetIncome);
            Assert.Equal("450", target.PaySlip_Super);
        }

        [Fact]
        public void Payee_CheckString()
        {
            var target = new Payee("Ryan", "Chen", "120000", "10%", new PayPeriod(3));
            var result = target.PaySlip;

            Assert.Equal("Ryan Chen,01 March to 31 March,10000,2669,7331,1000", result);
        }
    }
}
