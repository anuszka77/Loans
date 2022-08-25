using Loans.Domain.Applications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    public class LongTermShould
    {
        [Test] 
        public void ReturnTermInInMonths()
        {
            //Arrange
            var sut = new LoanTerm(1);

            //Assert

            Assert.That(sut.Years, Is.EqualTo(1));
        }



        [Test]
        public void ReturnTermInInYears()
        {
            //Arrange
            var sut = new LoanTerm(1);

            //Assert

            Assert.That(sut.ToMonths, Is.EqualTo(12), "Customowy komunikat :)");

        }

        [Test]
        public void CheckIfLoanTermsAreEqualIfYearsAreEquals()
        {
            //Arrange
            var loan1 = new LoanTerm(1);
            var loan2 = new LoanTerm(1);

            //Assert

            Assert.That(loan1, Is.EqualTo(loan2));

        }

        [Test]
        public void CheckIfTermInInYearsAreNotEquals()
        {
            //Arrange
            var loan1 = new LoanTerm(1);
            var loan2 = new LoanTerm(1);

            //Assert

            Assert.That(loan1, Is.Not.SameAs(loan2));

        }

        [Test]
        public void CheckIfTermInInYearsAreEquals()
        {
            //Arrange
            var loan1 = new LoanTerm(1);
            var loan3 = loan1;

            //Assert

            Assert.That(loan1, Is.SameAs(loan3));

        }

        [Test]
        public void CheckIfTwoListsAreEquals()
        {
            //Arrange
            var list1 = new List<string>
            {
                "test"
            };
            var list2 = new List<string>
            {
                "test"
            };

            var list3 = list1;

            //Assert
            Assert.That(list1, Is.EqualTo(list2));

            Assert.That(list1, Is.SameAs(list3));

        }


        [Test]
        public void SumTwoDouble()
        {

            //Assert
            Assert.That(0.1 + 0.2, Is.EqualTo(0.3).Within(0.1));

        }

        [Test]
        public void DivideTwoDouble()
        {

            //Assert
            Assert.That(1.0 / 3.0, Is.EqualTo(0.3333).Within(0.1));

        }

        [Test]
        public void CompareMonthlyRepaymentsCount()
        {
            //Arrange
            var loanAmount = new LoanAmount("PLN",23000);

            var listLoanProduct = new List<LoanProduct>
            {
                new LoanProduct(1, "mieszkanie", 6.5m),
                new LoanProduct(2, "auto", 9.5m),
                new LoanProduct(3, "wakcje", 1.5m)
            };

            var product = new ProductComparer(loanAmount, listLoanProduct);

            //Act
            var result = product.CompareMonthlyRepayments(new LoanTerm(30));

            //Assert
            Assert.That(result, Has.Exactly(listLoanProduct.Count).Items);
            //Assert.AreEqual(listLoanProduct.Count, result.Count);
           // Assert.That(listLoanProduct.Count, Is.EqualTo(result.Count));

        }

        [Test]
        public void CompareMonthlyRepaymentsUniqueElements()
        {
            //Arrange
            var loanAmount = new LoanAmount("PLN", 23000);

            var listLoanProduct = new List<LoanProduct>
            {
                new LoanProduct(1, "mieszkanie", 6.5m),
                new LoanProduct(2, "auto", 9.5m),
                new LoanProduct(3, "wakcje", 1.5m)
            };

            var product = new ProductComparer(loanAmount, listLoanProduct);

            //Act
            var result = product.CompareMonthlyRepayments(new LoanTerm(30));

            //Assert
            CollectionAssert.AllItemsAreUnique(result);

        }


        [Test]
        public void CompareMonthlyRepaymentsFirstElement()
        {
            //Arrange
            var loanAmount = new LoanAmount("PLN", 23000);

            var listLoanProduct = new List<LoanProduct>
            {
                new LoanProduct(1, "mieszkanie", 6.5m),
                new LoanProduct(2, "auto", 9.5m),
                new LoanProduct(3, "wakcje", 1.5m)
            };

            var product = new ProductComparer(loanAmount, listLoanProduct);

            //Act
            var result = product.CompareMonthlyRepayments(new LoanTerm(30));

            var resultFirst = result[0];

            //Assert
            Assert.That(resultFirst.ProductName, Is.EqualTo(listLoanProduct[0].GetProductName()));
            Assert.That(resultFirst.InterestRate, Is.EqualTo(listLoanProduct[0].GetInterestRate()));

        }

        [Test]
        public void CompareMonthlyRepaymentsFirstElementMonthlyAmount()
        {
            //Arrange
            var loanAmount = new LoanAmount("PLN", 23000);

            var listLoanProduct = new List<LoanProduct>
            {
                new LoanProduct(1, "mieszkanie", 6.5m),
                new LoanProduct(2, "auto", 9.5m),
                new LoanProduct(3, "wakcje", 1.5m)
            };

            var product = new ProductComparer(loanAmount, listLoanProduct);

            //Act
            var result = product.CompareMonthlyRepayments(new LoanTerm(30));

            var resultFirstMonthlyRepayment = result[0].MonthlyRepayment;

            //Assert
            Assert.Greater(resultFirstMonthlyRepayment, 0);

        }

        [Test]
        public void LoanTermException()
        {

            //Assert
            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
                     .With
                     .Message
                     .EqualTo("Please specify a value greater than 0. (Parameter 'years')"));
        }

       
        [TestCaseSource(typeof(MonthlyRepaymentCsvData), "GetTestCases", new object[] { "Data.csv" })]
        public void CsvData()
        {
            var sut = new LoanRepaymentCalculator();

            var monthlyPayment = sut.CalculateMonthlyRepayment(
                                        new LoanAmount("USD", principal),
                                        interestRate,
                                        new LoanTerm(termInYears));

            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));

            //Assert
            //Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>()
            //         .With
            //         .Message
            //         .EqualTo("Please specify a value greater than 0. (Parameter 'years')"));
        }

    }
}
