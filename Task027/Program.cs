// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = - number;
int SumDig(int num)
{
    int i;
    int a = 0;
    for (i = 0; num > 0; i++)
    {
        a = a + num % 10;
        num = num / 10;
    }
   return a;
}
int result = SumDig(number);
Console.WriteLine(result);