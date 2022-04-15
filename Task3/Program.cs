using System;
using static System.Console;

Console.Clear(); 
/*3. Напишите программу, которая будет принимать на
вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то
программа выводит остаток от деление.*/
WriteLine("Введите первое число");
int num1 =  Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int num2 =  Convert.ToInt32(ReadLine());
/*if(num1 % num2 == 0)
    WriteLine("Кратное число");
else
    WriteLine("Не кратное, остаток = " + num1 % num2);*/

string answer = num1 % num2 == 0?"Кратно":$"Не кратное, остаток - {num1 % num2 }";
 WriteLine(answer);
