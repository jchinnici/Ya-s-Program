using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class FindWordinString
    {
        string book = "the cat wears a red hat but the hat wasnt red to everyone else";
        public FindWordinString(string book)
        {for (var i = 0; i < book.Length - 1; i++)
                if(book.IndexOf("hat") == i)
                    book.Substring(i);
            Console.WriteLine(book.IndexOf("hat"));
            
        //if you find the "hat" we need to substring the string to start at the point after that first hat
        // while loop while(book.indexof('hat') == -1)
        // recursion call function inside a function need an end condition 
        }
    }
}
