using System;

/*Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа*/

Console.Clear(); 

int num = new Random().Next(100,1000);
string numS=num.ToString();
int first = Convert.ToInt32(numS[0].ToString());
int third = Convert.ToInt32(numS[2].ToString());

/*int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[2].ToString());
Console.WriteLine($"{num}>{a1}{a2}");*/
Console.WriteLine(num);
Console.Write(first);
Console.WriteLine(third);


