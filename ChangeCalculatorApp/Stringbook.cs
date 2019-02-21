using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class FindWordinString
    {
        static string book = "the cat wears a red hat but the hat wasnt red to everyone else";

            static int count = 0;
            public static void FindWordString()
            {while (book.IndexOf("hat") == -1)
            {
                Console.WriteLine($"number of hats + {count}");
                count++;
            }

            //if you find the "hat" we need to substring the string to start at the point after that first hat
            // while loop while(book.indexof('hat') == -1)
            // recursion call function inside a function need an end condition 
        }
    }
}
