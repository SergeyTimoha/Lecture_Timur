/*Задача 32:** Напишите программу замена элементов массива: положительные
 элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]

**Задача 33:** Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да*/

using System;
Console.Clear();


int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
int a = 0;
while (a < 12)
{
    Console.Write($"{array[a]*-1} ");
    a++;
}
/*int positiveSum = 0;
int negativeSum = 0;
foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}
Console.WriteLine($"Positive sum = {positiveSum}, Negative Sum = {negativeSum}");
*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}


