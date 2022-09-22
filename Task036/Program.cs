// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        if(i % 2 != 0) j = j + array[i];
    }
    return j;
}
int[] arr = CreaateArrayRndInt(10, - 20, 20);
PrintArray(arr);
Console.WriteLine();
int result = Counter(arr);
Console.WriteLine(result);