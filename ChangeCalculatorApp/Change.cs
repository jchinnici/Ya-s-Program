using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class MathJoe
    {
        private decimal dlr = 1.00m;
        private decimal qtr = .25m;
        private decimal dme = .10m;
        private decimal nkl = .05m;
        private decimal pny = .01m;

        public MathJoe(decimal change)
        {
            int nmbrOfDlr = 0;
            if(change >= dlr)
            {
                nmbrOfDlr = Convert.ToInt32(Math.Floor(change / dlr));
                change = change - nmbrOfDlr * dlr;
                Console.WriteLine($"{nmbrOfDlr} dollars");
            }
            if(change >= qtr)
            {
                var nmbrOfQtr = Convert.ToInt32(Math.Floor(change / qtr));
                change = change - nmbrOfQtr * qtr;
                Console.WriteLine($"{nmbrOfQtr} quarters");
            }
            if(change >= dme)
            {
                var nmbrOfDme = Convert.ToInt32(Math.Floor(change / dme));
                change = change - nmbrOfDme * dme;
                Console.WriteLine($"{nmbrOfDme} dimes");
            }
            if(change >= nkl)
            {
                var nmbrOfNkl = Convert.ToInt32(Math.Floor(change / nkl));
                change = change - nmbrOfNkl * nkl;
                Console.WriteLine($"{nmbrOfNkl} nickels");
            }
            if(change >= pny)
            {
                var nmbrOfPny = Convert.ToInt32(Math.Floor(change / pny));
                change = change - nmbrOfPny * pny;
                Console.WriteLine($"{nmbrOfPny} pennies");
            }Console.Read();
            

        }
    }
}
