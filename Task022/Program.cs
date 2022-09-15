// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
int count = 0;
while (count <= num1)
{
    int b = count * count;
    Console.WriteLine($"{count} {b}");
    count++;
}