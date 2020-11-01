using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FutureCalculator.Models
{
    public class FutureValueModel
    { 
        [Required (ErrorMessage ="Please enter a monthly investment")]
        [Range(1,500,ErrorMessage ="Montly Investment must be between 1 and 500")]
        public decimal? MonthlyInvestment { get; set; }

        [Required(ErrorMessage = "Please enter a Yearly investment")]
        [Range (0.1,10.0, ErrorMessage = "Yearly Interest rate must be between 0.1 and 10.0)")]
        public decimal?  YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter a Number of years")]
        [Range(1, 50, ErrorMessage = "Number of years  must be between 1 and 50)")]
        public int? Years { get; set; }

        public decimal? Calculate() {
            int? months = Years * 12;
            decimal? monthltInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;

            for (var  i = 0; i< months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthltInterestRate);
            }

            return futureValue;
        }
    }
}
