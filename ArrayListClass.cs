using System;
using System.Collections;

namespace CollectionArraylist1
{
  public  class Program
    {
      
       public static void Arraylistdemo1()
       {  
            // Array List in Collection Add,  insert, Remove, RemoveRange
            ArrayList arrlist = new ArrayList(); 
        	arrlist.Add("Mani");
        	arrlist.Add(552);
            arrlist.Insert(0,"EployeeDetails");
        	arrlist.Add("Software Developer");
            arrlist.Add(null);
            arrlist.Add(null);
            arrlist.Add(null);
            arrlist.Add(null);
            arrlist.Add(null);
            arrlist.Add(9876543210);
            arrlist.Insert(4,"trianee");

            arrlist.Remove(null);    // remove Firist null
            arrlist.RemoveRange(5,4);    //Four Postion index in Remove 3 null values

          // Convert Object value are Refernce type to Value type 
               //Explict type Casting are unbox type
            string name = (string)arrlist[1];
            int employeeNumber =(int)arrlist[2];
            Console.WriteLine("ArrayList Frist Inde Position 1 : " + name);
            Console.WriteLine("ArrayList Frist Inde Position 2 : " + employeeNumber);


            Console.WriteLine("ArrayList Count: " + arrlist.Count);
            Console.WriteLine("ArrayList Capacity: " + arrlist.Capacity);
            
            // Array List in Collection Add,  insert
            
            ArrayList arrlist1 =  new ArrayList();        // Second ArrayList
            arrlist1.Add("Anthor Employee Details");
            arrlist1.Add("Balan");
            arrlist1.Insert(1,553);

            arrlist.AddRange(arrlist1);   //Second Array List are join Frist arrayList 

            
             // Array List in Collection Add,  insert, InsertRange,RemoveAt
            ArrayList arrlist2 =  new ArrayList() {"Total Employee Details"} ;         // Thrid Array List
            arrlist2.Add("*** Mmy Company Employees ***");
            arrlist2.Add("*** Mmy Company Employees details ***");
            arrlist2.Insert(1,"Summa");
            arrlist2.RemoveAt(1);    // remove 2 postion Thrid Array List Value

            arrlist.InsertRange(0,arrlist2);   //Thrid Array List are join Frist arrayList 
           

            // Array List in Collection Add,  insert, Reverse, Clear
            ArrayList arrlist3 =  new ArrayList() {"Details",1,2,3} ;     // Four Array List
            arrlist3.Add(9876543210);
            arrlist3.Insert(2,"trianees");
            arrlist3.Reverse();
            arrlist3.Clear();
            arrlist.AddRange(arrlist3);   //Four Array List are join Frist arrayList 
          

            foreach (var item in arrlist)
        	{
          	  Console.WriteLine("Arraylist Elemnt :{0}",item);
        	}
             Console.WriteLine("Given Value is :{0}",arrlist.Contains("trianee"));
            Console.ReadLine();
           
    	}


        static void Main(string[] args)
        {
            Arraylistdemo1();
        }
    }
}
