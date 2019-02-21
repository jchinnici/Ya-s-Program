using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    class Insertionstuff
    {
        static int[] array = new int[] { 4, 1, 2, 7, 15, 2, -1, 7, 3, 9, 10, 1, 8 };
        public Insertionstuff()
        {
            Insert_sort();
        }
        public static void Insert_sort()
        {
            int tmp;
            //O^n 
            for (int i = 0; i < array.Length; i++)
            {
                for (int l = 0; l < array.Length; l++)
                {
                    if (array[i] < array[l])
                    {
                        tmp = array[l];
                        array[l] = array[i];
                        array[i] = tmp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + ", ");
            }
            Console.Read();

            //Console.WriteLine(string.Join(array.select(x => ""+x)));    link queue function similar to a for loop select means return an array that takes everything and add it to a string
        }
    }
}
