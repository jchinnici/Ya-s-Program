using System;

namespace ChangeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //inside a function variables are all lower case


            Decimal qtr = 0.25m;
            Decimal pny = 0.01m;
            Decimal nkl = 0.05m;
            Decimal dme = 0.10m;
            Decimal dlr = 1.00m;
            int nmbDlr = 0;
            int nmbQtr = 0;
            int nmbDme = 0;
            int nmbNkl = 0;
            int nmbPny = 0;
            Console.WriteLine("Enter Payment");
            var payment = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cost");
            var cost = Decimal.Parse(Console.ReadLine());
            var change = payment - cost;
            
            new MathJoe(change);
            Console.WriteLine("Your change is " nmbrOfDlr)
        }
    }

}
