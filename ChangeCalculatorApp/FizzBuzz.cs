using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class FizzBuzz
    {
        //if word contains fizz only add buzz at end
        //if word contains buzz only and fizz in beginning
        //if word doesnt contain either add fizz and buzz
        public FizzBuzz(string text)
        {if (text == "fizzbuzz")
                //text.StartsWith();
                //text.EndsWith();
                Console.WriteLine(text);
            else if (text.StartsWith("fizz"))
                Console.WriteLine($"{text}buzz");
            else if (text.EndsWith("buzz"))
                Console.WriteLine($"fizz{text}");
            else Console.WriteLine($"fizz{text}buzz");
        }
            
    }
}
