// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите чило");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = - number;
int Count(int num)
{
    int i;
    for (i = 0; num > 0; i++)
    {
        num = num / 10;
    }
   return i;
}
int result = Count(number);
Console.WriteLine(result);