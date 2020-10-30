using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutureCalculator.Models
{
    public class FutureValueModel
    {
        public decimal MonthlyInvestment { get; set; }
        public decimal  YearlyInterestRate { get; set; }
        public int Years { get; set; }

        public decimal  Calculate() {
            int months = Years * 12;
            decimal monthltInterestRate = YearlyInterestRate / 12 / 100;
            decimal futureValue = 0;

            for (var  i = 0; i< months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthltInterestRate);
            }

            return futureValue;
        }
    }
}
