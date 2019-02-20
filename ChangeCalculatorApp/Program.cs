using System;

namespace ChangeCalculatorApp
{
    class Program
    {
        static void GetSixSums(int[] arr)
        {

            



        }

        static void Main(string[] args)
        {
            int[] intarray = new int[] { 1, 4, 2, 3, 3, 6, -1, 7, 5, 1 };
            Console.WriteLine($"{intarray[1]},{intarray[0]}");
            new GetPair(intarray);
            //inside a function variables are all lower case
            //int array find the biggest pair of numbers in a given sequence

            new FizzBuzz(Console.ReadLine());



            var queue = new SimpleQueue();
            queue.Push(10);
            queue.Push(15);

            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());

          
        
            Console.WriteLine("Enter Payment");
            var payment = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cost");
            var cost = Decimal.Parse(Console.ReadLine());
            var change = payment - cost;
            
            new MathJoe(change);
            
        }
    }

}
