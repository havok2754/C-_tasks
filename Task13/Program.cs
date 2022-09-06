// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
int num2 = num1;
if (num1 < 100 && num1 > -100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (num2 > 999 || num2 < -999)
    {
        num2 = num2 / 10;
    }
    num2 = num2 % 10;
    if (num2 > 0)
    {
        Console.WriteLine($"Третья цифра числа {num1} - {num2}");
    }
    else Console.WriteLine($"Третья цифра числа {num1} - {-num2}");
}