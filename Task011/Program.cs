// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);

int Number2(int num)
{
int newnumber = (num / 100) * 10 + num % 10;
return newnumber;
}
int result = Number2(number);
Console.WriteLine($"{number} -> {result}");
