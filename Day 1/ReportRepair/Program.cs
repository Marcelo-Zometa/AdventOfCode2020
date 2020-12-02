using System;
using System.IO;

namespace ReportRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Report report = new Report();

            try
            {
                //var productOfTwoNumbers = report.twoNumbersThatAddTo2020();
                //Console.WriteLine("Product of number is " + productOfTwoNumbers);

                var productOfThreeNumbers = report.threeNumbersThatAddTo2020();
                Console.WriteLine("Product of number is " + productOfThreeNumbers);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
