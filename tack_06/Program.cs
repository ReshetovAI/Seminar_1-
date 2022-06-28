/*
Напишите программу, которая принимает на вход трёхзначное числo
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Введите трехзначное число N: ");
string numberN  = Console.ReadLine();
if (Convert.ToInt32(numberN) < 100 || Convert.ToInt32(numberN) > 999)
{
    Console.Write($"Введеннное число {numberN} не трехзначное");
}
else
{
    Console.Write($"Последняя цифра числа {numberN} -> {numberN.Substring(numberN.Length-1)}");
}
