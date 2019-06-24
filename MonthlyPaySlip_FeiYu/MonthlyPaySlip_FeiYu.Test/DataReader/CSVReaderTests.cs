using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using MonthlyPaySlip_FeiYu.DataReader;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.Test.DataReader
{
    public class CSVReaderTests
    {
        [Fact]
        public void ReadCSVFile_Success()
        {
            var target = new CSVReader();
            var result = target.ReadCSVFile().ToList();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void GetPayeesInfo_Success()
        {
            CSVReader target = new CSVReader();
            List<Payee> result = target.GetPayeesInfo();

            Assert.Equal(2, result.Count);
        }
    }
}
