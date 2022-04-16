using System;
using static System.Console;
//Максимальное число из трёх
Console.Clear(); 

WriteLine("Введите первое число");
int num1 =  Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int num2 =  Convert.ToInt32(ReadLine());

/*string result = (num1 * num1 == num2 || num2 * num2 == num1 )?$"Одно из чисел является квадратом другого":
$"Одно из чисел не является квадратом другого";
WriteLine(result);*/

string result = (num1 * num1 == num2)?$"{num1} Является квадратом числа {num2}":
(num2 * num2 == num1)?$"{num2} Является квадратом числа {num2}" : $"Не является квадратом числп";
WriteLine(result);
