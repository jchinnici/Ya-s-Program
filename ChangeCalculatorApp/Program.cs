using System;

namespace ChangeCalculatorApp
{
    class Program
    {
        static int GetMaxSum(int[] arr) {
            int lastGreatest = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1 && arr[i] > lastGreatest)
                        return arr[i];

                var currentSum = arr[i] + arr[i + 1];
                if (lastGreatest < currentSum)
                    lastGreatest = currentSum;
                
            }
            return lastGreatest;
        }

        static void Main(string[] args)
        {
            
            //inside a function variables are all lower case
            //int array find the biggest pair of numbers in a given sequence
            int[] intarray = new int[] { 1, 7, -3, 8, 2, 6, -1, 8, -2, 100 };
            Console.WriteLine(GetMaxSum(intarray));
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
