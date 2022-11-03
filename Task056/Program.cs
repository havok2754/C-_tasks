// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
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

int SumRowElemenets(int[,] matrix, int i)
{
    int sumrow = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sumrow += matrix[i, j];
    }
    return sumrow;
}

int FindStr(int[,] matrix)
{
    int sumrow = SumRowElemenets(matrix, 0);
    int minsumrow = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int tempsumrow = SumRowElemenets(matrix, i);
        if (sumrow > tempsumrow)
        {
            sumrow = tempsumrow;
            minsumrow = i;
        }
    }
    return minsumrow;
}



int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int result = FindStr(matrix);
Console.WriteLine($"{result+1} - строкa с наименьшей суммой элементов ");