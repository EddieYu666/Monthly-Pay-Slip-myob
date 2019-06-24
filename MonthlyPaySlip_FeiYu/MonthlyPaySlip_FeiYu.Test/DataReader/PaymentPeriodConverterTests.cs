using System.Reflection;
using Xunit;
using Moq;
using CsvHelper;
using CsvHelper.Configuration;
using MonthlyPaySlip_FeiYu.DataReader;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataReader
{
    public class PaymentPeriodConverterTests
    {
        [Fact]
        public void PayPeriodConverter_Check()
        {
            var target = new PaymentPeriodConverter();
            Mock<IReaderRow> mock_IReaderRow = new Mock<IReaderRow>();
            Mock<MemberInfo> mock_MemberInfo = new Mock<MemberInfo>();
            PayPeriod result = (PayPeriod)target.ConvertFromString("01 March - 31 March", mock_IReaderRow.Object, new MemberMapData(mock_MemberInfo.Object));

            var Expect = new PayPeriod(3);
            Assert.Equal(Expect.PayMonthPeriod, result.PayMonthPeriod);
            Assert.Equal(Expect.StartDate, result.StartDate);
            Assert.Equal(Expect.EndDate, result.EndDate);
        }
    }
}
