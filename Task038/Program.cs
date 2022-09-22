// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
double[] CreaateArrayRndDouble (int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = size - 1; i >= 0; i--)
    {
        array[i] = rnd.NextDouble() * 100;
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
     }
    Console.Write("]");
}

double DiffMinMAx(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    double diff = max - min;
    diff = Math.Round(diff, 2);
    return diff;
}

double[] arr = CreaateArrayRndDouble(5);
PrintArray(arr);
Console.WriteLine();
double result = DiffMinMAx(arr);
Console.WriteLine($"Разница между максимальным и минимальным значением массива - {result}");