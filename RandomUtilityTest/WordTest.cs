using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Utility;

namespace RandomUtilityTest
{
    public class WordTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// check reverse word
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(ReverseWordTestCases))]
        public void Test_ReverseWord(KeyValuePair<string,string> testData)
        {
            //Arrange             
            //Act
            var actualResult = Word.ReverseWord(testData.Key);

            //Assert
            Assert.AreEqual(testData.Value, actualResult,
                "Reversing of word has failed for the word :" + testData.Key);

        }

        /// <summary>
        /// check reversewordAlt method
        /// </summary>
        /// <param name="testData"></param>
        [Test, TestCaseSource(nameof(ReverseWordTestCases))]
        public void Test_ReverseWordAlt(KeyValuePair<string, string> testData)
        {
            //Arrange             
            //Act
            var actualResult = Word.ReverseWordAlt(testData.Key);

            //Assert
            Assert.AreEqual(testData.Value, actualResult,
                "Reversing of word has failed for the word :" + testData.Key);
        }

        /// <summary>
        /// Test cases for reverseWord
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string,string> ReverseWordTestCases()
        {
            Dictionary<string,string> lstWords = new Dictionary<string, string>();
            lstWords.Add("Hello","olleH");
            lstWords.Add("Hello World!","!dlroW olleH");
            lstWords.Add("!@#$%^&*()", ")(*&^%$#@!");
            lstWords.Add("abc123","321cba");
           
            return lstWords;
        }


        #region associated class, struct 
        public struct TestWord
        {
            public string Word;
            public string ExpectedResult;
        }
        #endregion
    }
}
