// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] IntMatrixLinesColumnsChanger(int[,] matrix)
{
    int temp = default;
    int[,] matrix1 = new int [matrix.GetLength(0), matrix.GetLength(1)];
    if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Повернуть матрицу не возможно!");
    else 
            {
            for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)   
                    {   
                        matrix1[i, j] = matrix[j, i];
                      
                    }
        
                }
        
            } 
              
    return matrix1;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrixchange = IntMatrixLinesColumnsChanger(matrix);
PrintMatrix(matrixchange);