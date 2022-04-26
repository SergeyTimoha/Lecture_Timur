using System;
Console.Clear();
Console.WriteLine("Введите число ");
//int A = int.Parse(Console.ReadLine());
//Console.WriteLine(Summa(int.Parse(Console.ReadLine())));

/*int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
    
        sum+= i;

    }
    return sum;
}*/

Console.WriteLine(GetSum(int.Parse(Console.ReadLine())));
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSum(int a)
{
    int b = 0;
    while (a > 0)
    {
        b += a % 10;
        a /= 10;
    }
    return b;

}

