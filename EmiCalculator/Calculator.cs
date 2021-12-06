using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmiCalculator
{
    internal class Calculator
    {
        internal int Principal { private get; set; }
        internal double Interest { private get; set; }

        internal int Year { private get; set; }

        internal int NCompound { private get; set; }

        internal Result GetResult()
        {
            var emi = new Result();
            emi.calculate = CalculateEmi();
            return emi;
        }

        private double CalculateEmi()
        {
            double Total = 0;
           
            
                Total = Principal * Math.Pow((1 + Interest / NCompound),
                                        (NCompound * Year));

              
                Total = Total / (Year * NCompound);

                Total = Math.Round(Total, 2);

            



            return Total;

        }

    }
}
