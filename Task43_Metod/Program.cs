using System;
Console.Clear();
Console.WriteLine("Введите число ");
//int A = int.Parse(Console.ReadLine());
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Количество цифр введённого числа : {Count(num)}");
//Console.WriteLine(Count(int.Parse(Console.ReadLine())));

int Count(int num)
{
    int i = 0;
    while (num > 0)
    {
        num/=10;
        i++;
    }
    return i;
}


int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
    
        sum+= i;

    }
    return sum;
}

