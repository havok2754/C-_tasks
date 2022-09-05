// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.WriteLine("Введите трехзначное число");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 1000 && num1 > 99)
{
    num1 = num1 % 10;
    Console.WriteLine(num1);
}
else Console.WriteLine("Неверное число");