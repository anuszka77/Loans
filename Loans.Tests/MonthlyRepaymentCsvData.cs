using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Loans.Tests
{
    public class MonthlyRepaymentCsvData
    {
        public static IEnumerable GetTestCases(string csvFileName)
        {

            var csvLines = File.ReadAllLines(csvFileName);

            var testCases = new List<TestCaseData>();

            foreach (var line in csvLines)
            {
                string[] values = line.Replace(" ", "").Split(',');
        
                decimal principal = decimal.Parse(values[0]);
                decimal interestRate = decimal.Parse(values[1], CultureInfo.InvariantCulture);
                int termInYears = int.Parse(values[2]);
                decimal expectedRepayment = decimal.Parse(values[3], CultureInfo.InvariantCulture);

                testCases.Add(new TestCaseData(principal, interestRate, termInYears, expectedRepayment));
            }

            return testCases;


            //var testCases = new List<TestCaseData>
            //{
            //    new TestCaseData(200_000m, 6.5m, 30, 1264.14m),
            //    new TestCaseData(500_000m, 10m, 30, 4387.86m),
            //    new TestCaseData(200_000m, 10m, 30, 1755.14m)
            //};

        }
    }
}
