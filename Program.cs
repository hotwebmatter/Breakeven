/**
 * ######################################################
 * ##    Programming Assignment #7                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: October 20 2019               ##
 * ##    Purpose: Demonstrate usage of OOP concepts.   ##
 * ######################################################
 */
using System;
using static System.Console;

namespace Breakeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;

            // instantiate object by calling BreakEven constructor method
            BreakEven calculation = new BreakEven();

            // Get some values from the user interactively
            Write("Enter company name: ");
            calculation.CompanyName = ReadLine();
            Write("Enter selling price: ");
            inputValue = ReadLine();
            calculation.SellingPrice = double.Parse(inputValue);
            Write("Enter fixed overhead: ");
            inputValue = ReadLine();
            calculation.FixedOverhead = double.Parse(inputValue);
            Write("Enter fixed administrative salaries: ");
            inputValue = ReadLine();
            calculation.FixedAdminSalaries = double.Parse(inputValue);
            Write("Enter raw materials percent of selling price: ");
            inputValue = ReadLine();
            calculation.MaterialsPercentage = double.Parse(inputValue);
            Write("Enter labor cost percent of selling price: ");
            inputValue = ReadLine();
            calculation.LaborPercentage = double.Parse(inputValue);

            // generate output
            WriteLine("***********************************");
            WriteLine(calculation.ToString());
            ReadLine();
        }
    }
}
