﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] CreateArrayRndInt(int size)
{
int[] array = new int[size];
array[0] = 0;
array[1] = 1;
for (int i = 2; i < size; i++)
{
array[i] = array[i - 1] + array[i - 2];
}
return array;
}
void PrintArray(int[] array)
{
Console.Write($"Первые {number} чисел ряда Фибоначчи - ");
for (int i = 0; i < array.Length; i++)
{
if (i < array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}");
}
}
int[] arr = CreateArrayRndInt(number);
PrintArray(arr);