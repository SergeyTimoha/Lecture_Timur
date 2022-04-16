using System;
using static System.Console;
//Максимальное число из трёх
Console.Clear(); 

WriteLine("Введите первое число");
int a =  Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int b =  Convert.ToInt32(ReadLine());
WriteLine("Введите третье число");
int c =  Convert.ToInt32(ReadLine());


int max = (a > b && a > c)?a:(b > a && b > c)?b:c;
WriteLine("Число max = " + max);