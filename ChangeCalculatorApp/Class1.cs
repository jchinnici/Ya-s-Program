using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class MathJoe
    {
        private decimal qtr = .25m;
        private decimal dme = .10m;

        public MathJoe(decimal change)
        {
            if(change >= qtr)
            {
                var nmbrOfQrt = Convert.ToInt32(change) / qtr;
                change = change - nmbrOfQrt * qtr;
            }
            if(change >= dme)
            {

            }
        }
    }
}
