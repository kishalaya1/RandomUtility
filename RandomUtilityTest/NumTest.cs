using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
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
            lstNoData.Add(AddTestNoData(123,6));
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
            lstNoData.Add(AddTestNoData(-120, 0));
            lstNoData.Add(AddTestNoData(0, 0));
            return lstNoData;
        }

        /// <summary>
        /// add a single testNo Data
        /// </summary>
        /// <param name="inputNo"></param>
        /// <param name="expectedResult"></param>
        /// <returns></returns>
        private static TestNo AddTestNoData(int inputNo,int expectedResult)
        {
            TestNo singleTestNumber = new TestNo();
            singleTestNumber.No = inputNo;
            singleTestNumber.ExpectedResult = expectedResult;
            return singleTestNumber;
        }

        #region associated class, struct 
        public struct TestNo
        {
            public int No;            
            public int ExpectedResult;
        }
        #endregion
    }
}