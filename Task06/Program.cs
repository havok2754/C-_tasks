//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
num1 = num1 % 2;
if (num1 != 0)
{
    Console.WriteLine("Число не является чётным");
}
else Console.WriteLine("Число является чётным");
