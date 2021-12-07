using System;

namespace EmiApp.Cmdline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var emiRequest = new Request() { Principal = 100000, InterestRateInPercentage = 12, LoanDurationInYearCount = 2 };
            ICalculator emiCalculator = new Calculator();
           
            #region monthly compounding
            var emiMonthly = emiCalculator.CalculateMonthlyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiMonthly.ErrorMessage))
                Console.WriteLine($"Monthly EMI is {emiMonthly.EmiPayment}");
            else 
                Console.WriteLine(emiMonthly.ErrorMessage);
            #endregion 

            var emiDaily = emiCalculator.CalculateDailyEmi(emiRequest);
            if (string.IsNullOrEmpty(emiDaily.ErrorMessage))
                Console.WriteLine($"Daily EMI is {emiDaily.EmiPayment}");
            else
                Console.WriteLine(emiDaily.ErrorMessage);

            var emiContinous = emiCalculator.CalculateContinousEmi(emiRequest);
            if (string.IsNullOrEmpty(emiContinous.ErrorMessage))
                Console.WriteLine($"Continous EMI is {emiContinous.EmiPayment}");
            else
                Console.WriteLine(emiContinous.ErrorMessage);

            Console.ReadLine();
        }
    }
}

