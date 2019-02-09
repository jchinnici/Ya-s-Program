using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class IntoArray
    {            //just an array of characters
        string str = "test";
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        string[] strings = new string[] { "test1", "test2" };

        int[][] numbersofnumbers = new int[][] { new int[] { }, new int[] { } };
        public IntoArray()
        {
            //var test = numbers[0]; //how to read 1 unit from an array
            //var length = numbers.Length; // how to determine the length of an array 
            var newArray = new int[10];//10 defines the number of spaces
            for(int i = 0; i < 10; i++)
            {
                newArray[i] = i;
            }
            foreach (var item in newArray)
                Console.Write($"{item}, ");//no new line for Write as opposed to writeline, the $ allows you to call a var defined in brackets
           
        }

    }
}
