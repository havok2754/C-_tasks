﻿// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Clear();
int[] CreaateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = size - 1; i >= 0; i--)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
     }
    Console.Write("]");
}

int[] Zamena(int[] array)
{
       for (int i = 0; i < array.Length; i++)
    {
      array[i] = - array[i];
    }
    return array;
}

int[] arr = CreaateArrayRndInt(12, -9, 9);
PrintArray(arr);
Console.WriteLine();
int[] result = Zamena(arr);
PrintArray(result);
Console.WriteLine();