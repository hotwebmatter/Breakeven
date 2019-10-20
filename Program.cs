/**
 * ######################################################
 * ##    Programming Assignment #7                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: October 20 2019               ##
 * ##    Purpose: Demonstrate usage of OOP concepts.   ##
 * ######################################################
 */
using System;

namespace Breakeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            string name;
            double price;
            double overhead;
            double salaries;
            double materials;
            double labor;
            Write("Enter company name: ");
            name = ReadLine();
            Write("Enter selling price: ");
            inputValue = ReadLine();
            price = double.Parse(inputValue);
            Write("Enter fixed overhead: ");
            inputValue = ReadLine();
            overhead = double.Parse(inputValue);
            Write("Enter fixed administrative salaries: ");
            inputValue = ReadLine();
            salaries = double.Parse(inputValue);
            Write("Enter raw materials percent of selling price: ");
            inputValue = ReadLine();
            materials = double.Parse(inputValue);
            Write("Enter labor cost percent of selling price: ");
            inputValue = ReadLine();
            labor = double.Parse(inputValue);

            // instantiate object by calling BreakEven constructor method
            BreakEven calculation = new BreakEven();

        }
    }
}
