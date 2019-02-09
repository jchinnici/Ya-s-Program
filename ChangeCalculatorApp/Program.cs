using System;

namespace ChangeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //inside a function variables are all lower case

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
