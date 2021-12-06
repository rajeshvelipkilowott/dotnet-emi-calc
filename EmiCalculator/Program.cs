// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace EmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i;
            int p, y, n;
            try
            {
                Console.Write("Enter the principal Amount : ");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Rate of Interest : ");
                i = Convert.ToInt32(Console.ReadLine());
                double ROI = i / 100;
                Console.Write("Enter the Number of Years : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number of Times the Interest will be Compounded monthly : ");
                n = Convert.ToInt32(Console.ReadLine());

                var Obj = new Calculator();

                Obj.Principal = p;
                Obj.Interest = ROI;
                Obj.Year = y;
                Obj.NCompound = n;

                var res = Obj.GetResult();

                Console.WriteLine($"Monthly Emi: {res.calculate} INR");

                // memi = Total / n;
                // Console.Write("Calculated Compound Interest: ", memi);
            }
            catch (FormatException e)
            {

                Console.WriteLine("Please convert integer to double");
            }
            



            Console.ReadLine();
        }
    }
}
