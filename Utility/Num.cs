using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
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

        /// <summary>
        /// factorial in straight formula
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Factorial(int number)
        {
            int factorial = 1;
            //let's assume  it for only positive number
            //number! is for integer. number >0
            if (number > 0)
            {
                factorial = number;
                //formula : number! = (number)(number-1)... 1
                for (int multiplierNo = number - 1; multiplierNo > 0; multiplierNo--)
                {
                    factorial = factorial * multiplierNo;
                }
            }
            return factorial;
        }

        /// <summary>
        /// factorial using recursion
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int RecursionFactorial(int number)
        {
            int factorial = 1;
            //let's assume  it for only positive number
            //number! is for integer. number >0
            if (number > 0)
            {
                //formula : number! = (number)(number-1)... 1
                if (number == 1)
                {
                    factorial = 1;
                }
                else
                {
                    factorial = number * RecursionFactorial(number - 1);
                }
            }
            return factorial;
        }
        /// <summary>
        /// Checks whether a no is a prime no
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrimeNo(int number)
        {
            bool isPrime = true;
            //we start dividing the no from 2 onwards
            //since every no is divisble by 1
            if (number > 1)
            {
                for (int divisorNo = 2; divisorNo <= number - 1; divisorNo++)
                {
                    if (number % divisorNo == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            else
            {//  0 and 1 are not prime nos
                isPrime = false;
            }
            return isPrime;
        }

        /// <summary>
        /// checks for a prime number in efficient
        /// matter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPrimeNoComplex(int number)
        {
            bool isPrime = true;
            //we start dividing the no from 2 onwards
            //since every no is divisible by 1
            if (number > 1)
            {
                // keep checking till square root .no need to check beyond
                ///that
                int maxDivisor = Convert.ToInt32(Math.Sqrt(number));
                //skip checking for division by an even number
                //because if the number is divisible by 2 
                //and it will escape the loop flagging isprime= false
                //also all even number by definition is divisible by 2.
                bool evenDivisor = true;
                for (int divisorNo = 2; divisorNo <= maxDivisor; divisorNo++)
                {
                    if (divisorNo <=2 || evenDivisor == false)
                    {
                        if (number % divisorNo == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    evenDivisor = SwitchState(evenDivisor);
                }
            }
            else
            {//  0 and 1 are not prime nos
                isPrime = false;
            }
            return isPrime;
        }
        
        /// <summary>
        /// switches the boolean state
        /// </summary>
        /// <param name="evenDivisor"></param>
        /// <returns></returns>
        private static bool SwitchState(bool evenDivisor)
        {
            if (evenDivisor == true)
            {
                evenDivisor = false;
            }
            else
            {
                evenDivisor = true;
            }

            return evenDivisor;
        }
    }

}

