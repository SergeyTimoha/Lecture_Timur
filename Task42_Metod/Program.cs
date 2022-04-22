using System;
Console.Clear();
Console.WriteLine("Введите число А");
//int A = int.Parse(Console.ReadLine());
Console.WriteLine(Summa(int.Parse(Console.ReadLine())));

int Summa(int number)
{
    int sum = 0;
    for (int i = 0; i <= number; i++)
    {
    
        sum+= i;

    }
    return sum;
}


