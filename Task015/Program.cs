// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите порядковы номер дня недели");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 1 || num1 >7) Console.WriteLine("Дней недели всего семь");
else if (num1 == 6 || num1 == 7) Console.WriteLine("Этот день выходной");
else Console.WriteLine("Этот день не является выходным");
