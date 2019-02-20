using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class GetPair
    {
    int[] intarray = new int[] { 1, 4, 2, 3, 3, 6, -1, 7, 5, 1 };
    
        
    public GetPair(int[] intarray)
        {
            for (var i = 0; i < intarray.Length - 1; i++)
                if (intarray[i] + intarray[i + 1] == 6)
                    Console.WriteLine($"{intarray[i]},{intarray[i + 1]}");
        }
    

    }
    
}
