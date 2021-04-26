using System;


class Program
{
static void Main()
{
Console.WriteLine("Enter a sentence");
String s = Console.ReadLine();
String p="";
for (int i = 0; i < s.Length; i++)
{
if (!(p.Contains(s[i])))
{
if(Char.IsWhiteSpace(s[i]))
{
p += " ";
}
else
{
p += s[i];
}
}
}
Console.WriteLine(p);
Console.ReadLine();
}
}
}