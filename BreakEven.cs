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
        double totalFixedCosts;
        double materialsPercentage;
        double laborPercentage;
        double totalVariableCostPercentage;
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
        public double TotalFixedCosts
        {
            get // accessor method
            {
                return totalFixedCosts;
            }
        }
        public double TotalVariableCostPercentage
        {
            get // accessor method
            {
                return totalVariableCostPercentage;
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
        private void CalculateBreakEven()
        {
            totalVariableCostPercentage = (materialsPercentage + laborPercentage) / 100;
            contributionMargin = sellingPrice * totalVariableCostPercentage;
            totalFixedCosts = fixedOverhead + fixedAdminSalaries;
            breakevenUnits = Math.Ceiling(totalFixedCosts / contributionMargin);
            breakevenDollars = Math.Ceiling(sellingPrice * breakevenUnits);
        }

        public override string ToString()
        {
            CalculateBreakEven();
            string result;
            result = string.Format("\t{0}\n", companyName);
            result += string.Format("Total fixed costs\t{0:C}\n", totalFixedCosts);
            result += string.Format("Total variable percent\t{0:p}\n", totalVariableCostPercentage);
            result += string.Format("Break even units are\t{0}\n", breakevenUnits);
            result += string.Format("Break even sales are\t{0:C}\n", breakevenDollars);
            return result;
        }
    }
}
