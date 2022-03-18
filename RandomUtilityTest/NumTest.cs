using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Utility;


namespace RandomUtilityTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// check sum of digits
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(SumOfDigitTestCases))]
        public void Test_SumOfDigits(TestNo testData)
        {
            //Arrange             
            //Act
            var result = Num.SumOfDigits(testData.No);

            //Assert
            Assert.AreEqual(testData.ExpectedResult, result,
                "SumOfDigits has failed for the number :" + testData.No);

        }

        /// <summary>
        /// Test Cases for sum of digits
        /// </summary>
        /// <returns></returns>
        private static List<TestNo> SumOfDigitTestCases()
        {
            List<TestNo> lstNoData = new List<TestNo>();
            lstNoData.Add(AddTestNoData(123, 6));
            lstNoData.Add(AddTestNoData(0, 0));
            lstNoData.Add(AddTestNoData(-123, 6));

            return lstNoData;
        }

        /// <summary>
        /// check factorial of a number
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(FactorialTestCases))]
        public void Test_Factorial(TestNo testData)
        {
            //Arrange             
            //Act
            var result = Num.Factorial(testData.No);

            //Assert
            Assert.AreEqual(testData.ExpectedResult, result,
                "Factorial has failed for the number :" + testData.No);

        }

        /// <summary>
        /// check factorial of a number
        /// using recursion
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(FactorialTestCases))]
        public void Test_RecursionFactorial(TestNo testData)
        {
            //Arrange             
            //Act
            var result = Num.RecursionFactorial(testData.No);

            //Assert
            Assert.AreEqual(testData.ExpectedResult, result,
                "Factorial has failed for the number :" + testData.No);

        }

        /// <summary>
        /// Test Cases for factorial
        /// </summary>
        /// <returns></returns>
        private static List<TestNo> FactorialTestCases()
        {
            List<TestNo> lstNoData = new List<TestNo>();
            lstNoData.Add(AddTestNoData(1, 1));
            lstNoData.Add(AddTestNoData(2, 2));
            lstNoData.Add(AddTestNoData(5, 120));
            lstNoData.Add(AddTestNoData(-120, 1));
            lstNoData.Add(AddTestNoData(0, 1));
            return lstNoData;
        }


        /// <summary>
        /// test case for IsPrimeNo method
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(PrimeNoTestCases))]
        public void Test_IsPrime(KeyValuePair<int, bool> testData)
        {
            //Arrange             
            //Act
            var result = Num.IsPrimeNo(testData.Key);

            //Assert
            Assert.AreEqual(testData.Value, result,
                "Prime No test has failed for the number :" + testData.Key);

        }

        /// <summary>
        /// test case for IsPrimeNoComplex method
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(PrimeNoTestCases))]
        public void Test_IsPrimeNoComplex(KeyValuePair<int, bool> testData)
        {
            //Arrange             
            //Act
            var result = Num.IsPrimeNoComplex(testData.Key);

            //Assert
            Assert.AreEqual(testData.Value, result,
                "Prime No test has failed for the number :" + testData.Key);

        }

        /// <summary>
        /// test cases for prime nos
        /// </summary>
        /// <returns></returns>
        private static Dictionary<int, bool> PrimeNoTestCases()
        {
            Dictionary<int, bool> lstNos = new Dictionary<int, bool>();
            lstNos.Add(0, false);
            lstNos.Add(1, false);
            lstNos.Add(2, true);
            lstNos.Add(3, true);
            lstNos.Add(4, false);
            lstNos.Add(5, true);
            lstNos.Add(6, false);
            lstNos.Add(7, true);
            lstNos.Add(53, true);
            lstNos.Add(99, false);
            return lstNos;
        }

        /// <summary>
        /// add a single testNo Data
        /// </summary>
        /// <param name="inputNo"></param>
        /// <param name="expectedResult"></param>
        /// <returns></returns>
        private static TestNo AddTestNoData(int inputNo, int expectedResult)
        {
            TestNo singleTestNumber = new TestNo();
            singleTestNumber.No = inputNo;
            singleTestNumber.ExpectedResult = expectedResult;
            return singleTestNumber;
        }

        /// <summary>
        /// test case for GetFibonacciSeries 
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(GetFibonacciSeriesTestCases))]
        public void Test_GetFibonacciSeries(TestFibonacci testData)
        {
            //Arrange             
            //Act
            var result = Num.GetFibonacciSeries(testData.No);

            //Assert
            Assert.AreEqual(testData.ExpectedResult, result,
                "Fibonacci series has wrong result for the number :" + testData.No);

        }

        /// <summary>
        /// test cases for Fibonaccci nos
        /// </summary>
        /// <returns></returns>
        private static List<TestFibonacci> GetFibonacciSeriesTestCases()
        {
            List<TestFibonacci> lstFibonacciNos = new List<TestFibonacci>();
            int[] fiboSeries = { 0 };

            lstFibonacciNos.Add(GetFibonacciTestData(0, null));
            lstFibonacciNos.Add(GetFibonacciTestData(1, fiboSeries));
            fiboSeries = new int[] { 0, 1 };
            lstFibonacciNos.Add(GetFibonacciTestData(2, fiboSeries));
            fiboSeries = new int[] { 0, 1, 1 };
            lstFibonacciNos.Add(GetFibonacciTestData(3, fiboSeries));
            fiboSeries = new int[] { 0, 1, 1, 2 };
            lstFibonacciNos.Add(GetFibonacciTestData(4, fiboSeries));
            fiboSeries = new int[] { 0, 1, 1, 2, 3 };
            lstFibonacciNos.Add(GetFibonacciTestData(5, fiboSeries));
            fiboSeries = new int[] { 0, 1, 1, 2, 3, 5 };
            lstFibonacciNos.Add(GetFibonacciTestData(6, fiboSeries));
            fiboSeries = new int[] { 0, 1, 1, 2, 3, 5, 8 };
            lstFibonacciNos.Add(GetFibonacciTestData(7, fiboSeries));
            return lstFibonacciNos;
        }
        private static TestFibonacci GetFibonacciTestData(int number, int[] fibSeries)
        {
            TestFibonacci fibonacciNo = new TestFibonacci(number);
            if (fibSeries != null)
            {
                fibonacciNo.ExpectedResult = fibSeries.ToList();
            }
            return fibonacciNo;
        }

        #region associated class, struct 
        public struct TestNo
        {
            public int No;
            public int ExpectedResult;
        }
        public struct TestFibonacci
        {
            public TestFibonacci(int number)
            {
                ExpectedResult = new List<int>();
                No = number;
            }
            public int No;
            public List<int> ExpectedResult;

        }
        #endregion
    }
}