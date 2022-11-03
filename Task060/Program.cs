// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.Clear();

int[,,] matrix3d = new int[2, 2, 2];
void CreateMatrix3d(int[,,] matrix3d)
{
//   int[,,] matrix3d = new int[2, 2, 2];
  int[] temp = new int[matrix3d.GetLength(0) * matrix3d.GetLength(1) * matrix3d.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < matrix3d.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3d.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3d.GetLength(2); k++)
      {
        matrix3d[i, j, k] = temp[count];
        count++;
      }
    }
  }
}


void WriteMatrix (int[,,] matrix3d)
{
  for (int i = 0; i < matrix3d.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3d.GetLength(1); j++)
    {
       for (int k = 0; k < matrix3d.GetLength(2); k++)
       {
         Console.Write($"{matrix3d[i,j,k]}({i},{j},{k})  ");
       }
    }
    Console.WriteLine();
  }
}

CreateMatrix3d(matrix3d);
WriteMatrix(matrix3d);