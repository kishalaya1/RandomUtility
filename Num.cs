using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUtility
{
    public static class Num
    {
        /// <summary>
        /// sum of digits of a number
        /// </summary>
        /// <param name="number">any integer no</param>
        /// <returns></returns>
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            //to ensure -ve integers are also taken care of 
            number = Math.Abs(number);          
            while (number != 0)
            {
                sum = sum + number % 10;
                number = number / 10;               
            }
            return sum;
        }
    }
}
