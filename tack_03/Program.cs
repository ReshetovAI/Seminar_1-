/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите номер дня недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());

if (dayweek == 1)
{
    Console.WriteLine($"день недели для номера дня {dayweek} понедельник");
}
if (dayweek == 2)
{
    Console.WriteLine($"день недели для номера дня {dayweek} вторник");
}
if (dayweek == 3)
{
    Console.WriteLine($"день недели для номера дня {dayweek} среда");
}
if (dayweek == 4)
{
    Console.WriteLine($"день недели для номера дня {dayweek} четверг");
}
if (dayweek == 5)
{
    Console.WriteLine($"день недели для номера дня {dayweek} пятница");
}
if (dayweek == 6)
{
    Console.WriteLine($"день недели для номера дня {dayweek} суббота");
}
if (dayweek == 7)
{
    Console.WriteLine($"день недели для номера дня {dayweek} воскресенье");
}

