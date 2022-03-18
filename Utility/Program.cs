using System;
using Utility;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter No : ");
            int inputNo = Convert.ToInt32(Console.ReadLine());
            //int result = Num.SumOfDigits(inputNo);
            //instead uncomment and call other functions
            //int result = Num.Factorial(inputNo);
            //var result = Num.isPrimeNo(inputNo);

            //uncomment and call other functionw in Word.cs

            //Console.WriteLine("Hello World! Please enter input : ");
            //int inputWord = Convert.ToString(Console.ReadLine());
            //individual can be uncoment and called
            //string result = Word.ReverseWord(inputWord);

            //fibonacci 
            var result = Num.GetFibonacciSeries(inputNo);
            foreach (var item in result)
            {
                Console.WriteLine("The result is : " + item);
            }
            //   Console.WriteLine("The result is : " + result);
        }
    }
}
