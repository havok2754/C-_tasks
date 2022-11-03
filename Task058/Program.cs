// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProdOfMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
  int[,] resultmatrix = new int[3, 3];  
  for (int i = 0; i < resultmatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultmatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultmatrix[i,j] = sum;
    }
  }
  return resultmatrix;
}

Console.WriteLine("Первая матрица");
int[,] firstmatrix = CreateMatrixRndInt(3, 3, 0, 5);
PrintMatrix(firstmatrix);
Console.WriteLine("Вторая матрица");
int[,] secondmatrix = CreateMatrixRndInt(3, 3, 0, 5);
PrintMatrix(secondmatrix);
Console.WriteLine("Результат произведения 2х матриц");
int[,] resultmatrix = ProdOfMatrix(firstmatrix, secondmatrix);
PrintMatrix(resultmatrix);
Console.WriteLine();
