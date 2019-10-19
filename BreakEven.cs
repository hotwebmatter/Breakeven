using System;
using System.Collections.Generic;
using System.Text;

namespace Breakeven
{
    class BreakEven
    {
        string companyName;
        double sellingPrice;
        double fixedOverhead;
        double adminSalaries;
        double materialsPercentage;
        double laborPercentage;
        double contributionMargin;
        double breakevenUnits;
        double breakevenDollars;

        public BreakEven()
        {
            // empty constructor, per specification
        }

        // properties -- accessors and mutators

        public string CompanyName
        {
            set // mutator method
            {
                companyName = value;
            }
        }
        public double SellingPrice
        {
            set // mutator method
            {
                sellingPrice = value;
            }
        }
        public double AdminSalaries
        {
            set // mutator method
            {
                adminSalaries = value;
            }
        }
        public double MaterialsPercentage
        {
            set // mutator method
            {
                materialsPercentage = value;
            }
        }
        public double LaborPercentage
        {
            set // mutator method
            {
                laborPercentage = value;
            }
        }
    }
}
