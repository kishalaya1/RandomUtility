using System;
using static RandomUtility.Num;

namespace RandomUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Please enter No : ");
            int inputNo = Convert.ToInt32(Console.ReadLine());
            int result = SumOfDigits(inputNo);
            Console.WriteLine("The result is : " + result);
        }
    }
}
