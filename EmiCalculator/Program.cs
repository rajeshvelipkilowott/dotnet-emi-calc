// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace EmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Total = 0, i, years, n, p, memi;
            Console.Write("Enter the principal Amount : ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            i = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded monthly : ");
            n = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = p * Math.Pow((1 + i / n),
                                         (n * t));
                Console.Write("Your Total for Month {0} "
                            + "is {1:F0}. \n", t, Total);

                
            }
           // memi = Total / n;
           // Console.Write("Calculated Compound Interest: ", memi);

            Console.ReadLine();
        }
    }
}
