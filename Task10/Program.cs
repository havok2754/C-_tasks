// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine());
int num2 = 0;
if (num1 < 100 || num1 > 999) Console.WriteLine("Число должно быть трехзначным");
else 
{
    num2 = num1 % 100 / 10;
    Console.WriteLine($"Вторая цифра числа {num1} -> {num2}");
}