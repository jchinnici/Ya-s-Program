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
                Console.WriteLine($"{nmbrOfDlr} : number of dollars");
            }
            if(change >= qtr)
            {
                var nmbrOfQrt = Convert.ToInt32(change) / qtr;
                change = change - nmbrOfQrt * qtr;
            }
            if(change >= dme)
            {
                var nmbrOfDme = Convert.ToInt32(change) / dme;
                change = change - nmbrOfDme * dme;
            }
            if(change >= nkl)
            {
                var nmbrOfNkl = Convert.ToInt32(change) / nkl;
                change = change - nmbrOfNkl * nkl;
            }
            if(change >= pny)
            {
                var nmbrOfPny = Convert.ToInt32(change) / pny;
                change = change - nmbrOfPny * pny;
            }
            

        }
    }
}
