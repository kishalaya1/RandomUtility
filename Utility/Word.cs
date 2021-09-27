using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Word
    {
        /// <summary>
        /// Reverses the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static string ReverseWord(string word)
        {
            string reversedWord = string.Empty;
            foreach (char individualLetter in word)
            {
                reversedWord = individualLetter + reversedWord;
            }
            return reversedWord;
        }
    }
}
