using System;
using System.Collections.Generic;
using System.IO;

namespace ReportRepair
{
    public class Report
    {
        public List<int> ExpensesList { get; set; }

        public Report()
        {
            ExpensesList = new List<int>();
            getExpenses();
        }        

        public void getExpenses()
        {
            var path = "C:/Users/engr/source/repos/AdventOfCode2020/Day 1/ReportRepair/input.txt";
            try
            {
                var input = File.ReadAllLines(path);
                
                foreach(string s in input)
                {
                    ExpensesList.Add(Int32.Parse(s));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File couldn't be read");
            }
        }
      
        public int twoNumbersThatAddTo2020()
        {
            foreach(int num1 in ExpensesList)
            {
                foreach(int num2 in ExpensesList)
                {
                    if (num1 + num2 == 2020)
                    {
                        Console.WriteLine($"Numbers are {num1} and {num2}");
                        return num1 * num2;                        
                    }
                }
            }

            throw new InvalidOperationException("Numbers not found");
        }

        public int threeNumbersThatAddTo2020()
        {
            foreach (int num1 in ExpensesList)
            {
                foreach (int num2 in ExpensesList)
                {
                    foreach(int num3 in ExpensesList)
                    {
                        if (num1 + num2 + num3 == 2020)
                        {
                            Console.WriteLine($"Numbers are {num1}, {num2} and {num3}");
                            return num1 * num2 * num3;
                        }
                    }
                }
            }

            throw new InvalidOperationException("Numbers not found");
        }
    }
}
