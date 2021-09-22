using System;
using static Utility.Num;

namespace Utility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter No : ");
            int inputNo = Convert.ToInt32(Console.ReadLine());
            int result = SumOfDigits(inputNo);
            //instead uncomment and call other functions
            //int result = Factorial(inputNo);
            //var result = isPrimeNo(inputNo);
            Console.WriteLine("The result is : " + result);
        }
    }
}
