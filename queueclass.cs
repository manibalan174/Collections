using System;
using System.Collections;
namespace QueueColection
{
  public  class Program
    {
        public static void demoQueue()
        {
         Queue queue1 = new Queue();    ///Declare the queue

         queue1.Enqueue("Name"); 
         queue1.Enqueue(45);          //Add the values in queue
          queue1.Enqueue(007);
          queue1.Enqueue(12.5);
         queue1.Enqueue("Employee No");
          int[] Array1 = {12,34,4556,67};
         //dequeueMethods(Array1);

        foreach(var item in Array1)
         {
             queue1.Enqueue(item);            //Add Arrray  Element in Queue
         }
         foreach(var item in queue1)
         {
                  Console.WriteLine("Queue Elemet : "+item);         //Display the Element in Queue
         }

         Console.WriteLine("Total Queue Count :"+queue1.Count);
          Console.WriteLine("Display Queue first Element :"+queue1.Peek());
         Console.WriteLine("Deleted Queue Element :"+queue1.Dequeue());
        
        Console.WriteLine(" *** Deleted Queue Element After Queue Printing *** ");

           foreach(var item in queue1)
         {
                  Console.WriteLine("Queue Elemet : "+item);
         }

        Console.WriteLine("Queue Count :"+queue1.Count);
        }
        // public static  void dequeueMethods(int[] arrays)
        // {
        //      Queue queue2 = new Queue();
        //       string Values = "Hello Every One it the time to Demo to All";
        //       queue2.Enqueue(Values);
        //        foreach(var item in arrays)
        //        {
        //            queue2.Enqueue(item);
        //        }
        //       while(queue2.Count > 0)
        //       {
        //             Console.WriteLine("Deleted Queue Element :"+queue2.Dequeue());
        //       }
        // }  
     public   static void Main(string[] args)
        {
            Console.WriteLine("*** Queue Concept ***");
          demoQueue();
        //  dequeueMethods();
        }
    }
}
