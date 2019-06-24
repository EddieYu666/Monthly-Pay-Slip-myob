using System;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.DataReader
{
    public class PaymentPeriodConverter : ITypeConverter
    {
        public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            string PaymentStartDate_String = text.Split(new char[] { '\u2013', '-' })[0];
            DateTime PaymentStartDate = DateTime.Parse(PaymentStartDate_String);
            int PeriodMonth = PaymentStartDate.Month;
            return new PayPeriod(PeriodMonth);
        }

        public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            throw new NotImplementedException();
        }
    }
}
