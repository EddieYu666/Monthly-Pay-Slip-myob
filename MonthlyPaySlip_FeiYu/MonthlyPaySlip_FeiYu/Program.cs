using System;
using MonthlyPaySlip_FeiYu.DataReader;
using MonthlyPaySlip_FeiYu.DataModels;
using System.Collections.Generic;

namespace MonthlyPaySlip_FeiYu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monthly Pay Slip ----- Fei Yu");

            CSVReader CsvInfo = new CSVReader();
            List<Payee> PayeesInfo = CsvInfo.GetPayeesInfo();

            Console.WriteLine();
            Console.WriteLine("name, pay period, gross income, income tax, net income, super");
            Console.WriteLine();

            foreach (Payee temp in PayeesInfo)
            {
                Console.WriteLine(temp.PaySlip);
            }

            Console.ReadLine();
        }
    }
}
