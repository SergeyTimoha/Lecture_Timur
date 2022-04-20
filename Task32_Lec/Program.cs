
/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
эта точка.*/

using System;
Console.Clear();
Console.WriteLine("ВВедите координаты х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("ВВедите координаты y: ");
int y = int.Parse(Console.ReadLine());
if (x> 0&& y>0)
{
    Console.WriteLine("Первая четверть");
}
if (x<0 && y>0)
{
    Console.WriteLine("Вторая четверть");
}
if (x<0 && y<0)
{
    Console.WriteLine("Третья четверть");
}
if (x>0 && y<0)
{
    Console.WriteLine("Четвёртая четверть");
}
else
{
    Console.WriteLine("Введена неправильная четверть");
}