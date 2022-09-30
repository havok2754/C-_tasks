// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.Clear();
// Console.WriteLine($"Введите номер строки элемента: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Введите номер столбца элемента: ");
// int b = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

void SeachElem(int[,] matrix)
{   
    Console.WriteLine($"Введите номер строки элемента: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите номер столбца элемента: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    if (a > matrix.GetLength(0) || b > matrix.GetLength(1)) Console.WriteLine($"Такого элемента нет");
    else 
    {
        object c = matrix.GetValue(a - 1, b - 1);  // Сделано -1, для удобства пользователя. Т.к. он не знает, что счёт идёт с 0.
        Console.WriteLine($"Элемент, находящиййся в {a} строке, в {b} столбце - {c}");
    }
  
}

int[,] matrix = CreateMatrixRndInt(6, 6, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
SeachElem(matrix);
Console.WriteLine();
