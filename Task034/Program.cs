﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int Counter(int[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) j++;
    }
    return j;
}
int[] arr = CreaateArrayRndInt(10, 99, 1000);
PrintArray(arr);
Console.WriteLine();
int result = Counter(arr);
Console.WriteLine(result);