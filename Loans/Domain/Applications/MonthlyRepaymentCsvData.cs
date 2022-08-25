using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Loans
{
    public class MonthlyRepaymentCsvData
    {
        public static IEnumerable GetTestCases(string csvFileName)
        {
            var testCases = new List<TestCaseData>
            {
                new TestCaseData(200_000m, 6.5m, 30, 1264.14m),
                new TestCaseData(500_000m, 10m, 30, 4387.86m),
                new TestCaseData(200_000m, 10m, 30, 1755.14m)
            };

            return testCases;
        }
    }
}
