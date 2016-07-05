using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Birthday_Party
{
    public class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = 20.00M;
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost()
                              + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (healthyOption)
                return totalCost * .95M;
            
            return totalCost;
        }
    }
}
