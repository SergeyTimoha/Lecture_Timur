using System;

Console.Clear();
int[] r = new int [5];
//string t = "123456789ghbd";
for (int i = 0; i < 5; i++)
{
    r[i] = new Random().Next(10);

}
//Console.WriteLine(String.Join(" , ",t.ToArray()));
Console.WriteLine(String.Join(" ,",r));