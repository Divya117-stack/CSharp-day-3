using System;
class Class1 
{
    void sum(int a, int b)
    {
        Console.WriteLine("sum of a+b =" + (a+b));
    }
    void sum(float a, float b)
    {
        Console.WriteLine("sum of a+b =" + (a+b));
    }
    void sum(double a, double b, double c)
    {
        Console.WriteLine("sum of a+b+c =" + (a+b+c));
    }
  static void Main() 
  {
    Class1 class2 = new Class1();
    class2.sum(5,6);
    class2.sum(1.2F,2.2F);
    class2.sum(11.32,22.22,30.34);
    Console.ReadLine();
  }
  }