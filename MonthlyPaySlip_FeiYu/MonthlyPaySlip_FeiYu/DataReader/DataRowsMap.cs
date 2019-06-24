using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration;

namespace MonthlyPaySlip_FeiYu.DataReader
{
    public class DataRowsMap : ClassMap<DataRows>
    {
        public DataRowsMap() {
            Map(m => m._FirstName);
            Map(m => m._LastName);
            Map(m => m._AnnualSalary);
            Map(m => m._SuperRate);
            Map(m => m._PayPeriod).TypeConverter<PaymentPeriodConverter>();
        }
    }
}
