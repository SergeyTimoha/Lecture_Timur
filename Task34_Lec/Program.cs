﻿using System;
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}