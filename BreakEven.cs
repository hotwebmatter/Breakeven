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
        double fixedAdminSalaries;
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
        public double FixedOverhead
        {
            set // mutator method
            {
                fixedOverhead = value;
            }
        }
        public double FixedAdminSalaries
        {
            set // mutator method
            {
                fixedAdminSalaries = value;
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

        public double ContributionMargin
        {
            get // accessor method
            {
                return contributionMargin;
            }
        }
        public double BreakevenUnits
        {
            get // accessor method
            {
                return breakevenUnits;
            }
        }
        public double BreakevenDollars
        {
            get // accessor method
            {
                return breakevenDollars;
            }
        }

    }
}
