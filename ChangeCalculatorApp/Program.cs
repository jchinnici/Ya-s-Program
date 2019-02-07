using System;

namespace ChangeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //test


            Decimal Qtr = 0.25m;
            Decimal Pny = 0.01m;
            Decimal Nkl = 0.05m;
            Decimal Dme = 0.10m;
            Decimal Dlr = 1.00m;
            int NmbDlr = 0;
            int NmbQtr = 0;
            int NmbDme = 0;
            int NmbNkl = 0;
            int NmbPny = 0;
            Console.WriteLine("Enter Payment");
            Decimal NmbOfPny = 0;
            var Payment = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cost");
            var Cost = Decimal.Parse(Console.ReadLine());
            var Change = Payment - Cost;
            Console.WriteLine("Your change is " + Change);



            while (Change >= Dlr)
            {
                NmbDlr++;
                Change = Change - Dlr;
            }


            Console.WriteLine("Dollars received " + NmbDlr);
            Console.Read();
        }
    }

}
