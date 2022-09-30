// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Clear();
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = size - 1; i >= 0; i--)
    {
        array[i, j] = rnd.NextDouble() * 100;
        array[i, j] = Math.Round(array[i, j], 1);
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

int[] CopyArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
    }
    return arr2;
}  
Console.WriteLine();
int[] arr = CreateArrayRndInt(9, 1, 5);
PrintArray(arr);
Console.WriteLine();
int[] arrcopy = CopyArray(arr);
PrintArray(arrcopy);