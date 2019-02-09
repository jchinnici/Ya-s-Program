using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculatorApp
{
    public class SimpleQueue

    {
        int[] currentQueue = null;
        public SimpleQueue()
        {

        }
        //add one item to back of queue
        public void Push(int item)
        {
            if (currentQueue == null)// == compare
            {
                currentQueue = new int[] { item };
                return;
            }
                
            //add to the back
            var newCurrentQueue = new int[currentQueue.Length + 1];
            for (int i = 0; i < currentQueue.Length; i++)
            {
                newCurrentQueue[i] = currentQueue[i];
            }
            newCurrentQueue[newCurrentQueue.Length - 1] = item;
            currentQueue = newCurrentQueue;// gets last element of the array no matter what call itself.lentgh minus 1 
            //newcurrentqueue[currentqueue.length + 1]
        }
        //return this first item in the queue
        public int Pop()
        {//redefine array and shift everyone over by 1
            var firstItem = currentQueue[0];
            var newCurrentQueue = new int[currentQueue.Length - 1];
            for(int i = 1; i < currentQueue.Length; i++)
            {
                newCurrentQueue[i-1] = currentQueue[i];
            }
            currentQueue = newCurrentQueue;
            return firstItem; // stops any progress
        }
       
        

    }
}
