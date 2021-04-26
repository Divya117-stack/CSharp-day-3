using System;
 class Program 
 {
     static void Main()
     {
     string name = "It is a bad color";
     string output = name.Substring(2,6);
     Console.WriteLine(output);
 }
 }
---------------------------------------------------
using System;
 class Program 
 {
     static void Main()
     {
     string name = "It is a bad color";
     if(name.Contains("is a"))
     {
         Console.WriteLine("String is present");
     }
     else
     {
        Console.WriteLine("String is absent"); 
     }
     }
 }