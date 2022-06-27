/*
Напишите программу, которая на вход принимает число
и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
Console.WriteLine("Введите число для возведения в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
int squareOfNumber = number * number;
Console.WriteLine($"Квадрат числа {number} равен {squareOfNumber}");