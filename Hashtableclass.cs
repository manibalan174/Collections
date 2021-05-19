using System;
using System.Collections;
namespace HashtableCollection
{
  public class Program
    {
        
        public static void hashtableDemo()
        {

             Hashtable hashtable1 = new Hashtable();    //declare hashtable
             hashtable1.Add("Name","Mani");
               hashtable1.Add("Employee No",553);     ///Add Function in hashtable
                 hashtable1.Add("Role","Devloper");
                   hashtable1.Add("No",9876543210);
                     hashtable1.Add(1,987605312);
                     hashtable1.Add(4,null);
                     hashtable1.Add(5,"Hello");
                      hashtable1.Add(6,null);
                     hashtable1.Remove(4);       //remove Key in hashtable
                     // hashtable1.Add("Employee No",5  53);
                      hashtable1[3]=3435;
                     // hashtable1[3]=null;
                         try
        	            {
                        	hashtable1.Add(3, 56);
        	            }
                        catch
        	            {
                            Console.WriteLine("An element with Key = '3' already exists.");
        	            }

                        string name =(string)hashtable1["Name"];
                        // int No1 =int.Parse(hashtable1["No"]); 
                        string postionFive = (string)hashtable1[5];  

                        Console.WriteLine("Print Indivdual hash Element : {0}",name);
                      //  Console.WriteLine("Print Indivdual hash Element : {0}",No1);
                        Console.WriteLine("Print Indivdual hash Element : {0}",postionFive);

                         Console.WriteLine("hashtable Key  : {0}",hashtable1.ContainsKey(1));
                         Console.WriteLine("hashtable Key  : {0}",hashtable1.ContainsValue(1));      //if check key are value active are not
                         Console.WriteLine("hashtable Key  : {0}",hashtable1.Contains(6));

                       
                    foreach(DictionaryEntry item in hashtable1)     //using For each Print Hashtable 
                     {
                         Console.WriteLine("Key = {0}\tValue = {1}",item.Key,item.Value);
                     }
                                      
                       foreach(var item in hashtable1.Keys)    ///print Hashtable Key only
                       {
                         Console.WriteLine("Key = {0}",item);
                       }
                        foreach(var item in hashtable1.Values)   //print hashtable Value only
                       {
                         Console.WriteLine("Values = {0}",item);
                       }

                       hashtable1.Clear();                       ///clear All hashtable Element
                       Console.WriteLine("hashtable Key  : {0}",hashtable1.Count);
    	}
               public static void Main(string[] args)
        {
            hashtableDemo();
        }
    }
}
