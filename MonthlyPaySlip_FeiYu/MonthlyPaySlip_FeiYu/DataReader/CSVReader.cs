using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using MonthlyPaySlip_FeiYu.DataModels;

namespace MonthlyPaySlip_FeiYu.DataReader
{
    public class CSVReader
    {
        public IEnumerable<DataRows> ReadCSVFile()
        {
            var FileReader = new StreamReader("InputData.csv");

            var Csv_Reader = new CsvReader(FileReader);
            Csv_Reader.Configuration.HasHeaderRecord = false;
            Csv_Reader.Configuration.RegisterClassMap<DataRowsMap>();

            try
            {
                var records = Csv_Reader.GetRecords<DataRows>().ToList();
                return records;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Payee> GetPayeesInfo()
        {
            IEnumerable<DataRows> info = ReadCSVFile();
            List<Payee> result = new List<Payee>();
            
            foreach (DataRows dataRow in info)
            {
                Payee payee = new Payee(dataRow._FirstName, dataRow._LastName, dataRow._AnnualSalary, dataRow._SuperRate, dataRow._PayPeriod);
                result.Add(payee);
            }

            return result;
        }
    }
}
