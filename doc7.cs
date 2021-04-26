using System;
 class Program 
 {
     static void Main()
     {
     string str1;
    char[] arr1;
       int len,i;
        len=0;
        char ch;
       Console.Write("Enter the string :" );
       str1 = Console.ReadLine();
       len=str1.Length;
       arr1 = str1.ToCharArray();
       for(i=0; i < len; i++)
         {
          ch=arr1[i];
           if (Char.IsLower(ch))
           {
              Console.Write(Char.ToUpper(ch)); 
           }
              else
              {
              Console.Write(Char.ToLower(ch)); 
              }
        }
     
   }