﻿/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN < 0)
{
    Console.WriteLine($"Не верный ввод число {numberN} отрицательное");
}
for (int i = -numberN; i <= numberN; i++)
{
    if (i != numberN)
    {
    Console.Write($"{i}, ");
    }
    else 
    {
    Console.Write($"{i}");
    }
}