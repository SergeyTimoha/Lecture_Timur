

using System;
Console.Clear();
Console.Write("Введите координаты х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты х2: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());


double c = ((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
Console.WriteLine($"{Math.Sqrt(c):f2}");

double d = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
Console.WriteLine($"{Math.Sqrt(d):f2}");
