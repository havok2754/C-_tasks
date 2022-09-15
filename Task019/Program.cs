// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999) Console.WriteLine("Число олжно быть пятизначным");
    int dig1 = num / 10000;
    int dig2 = num % 10000 / 1000;
    int dig3 = num % 100 / 10;
    int dig4 = num % 10;
    if (dig1 == dig4 && dig2 == dig3) Console.WriteLine($"Число {num} являеется полиндромом");
    else Console.WriteLine($"Число {num} не являеется полиндромом");
