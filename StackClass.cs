using System;
using System.Collections;

namespace StackCollection
{
   public class Program
    {
        public static void  stackDemo()
        {
             Stack stack1 = new Stack();   //Stack Delecaration
             stack1.Push("Mani");
        	stack1.Push(null);
        	stack1.Push(007);        //Add the values in Statck
            stack1.Push("Balan");
            stack1.Push(000.12);
            foreach(var item in stack1)
            {
              Console.WriteLine("Stack Element :"+item);
            }
           Console.WriteLine("Total Stack Count :"+stack1.Count);  //Count the values in Statck
          Console.WriteLine("Display Stack first Element :"+stack1.Peek());
         Console.WriteLine("Deleted Stack Element :"+stack1.Pop());   //deleted the values in Statck
         Console.WriteLine("Deleted after Stack Count :"+stack1.Count);
        }
    public    static void Main(string[] args)
        {
            stackDemo();
        }
    }
}
