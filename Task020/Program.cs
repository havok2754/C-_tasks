// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("ВВедите координаты первой точки");
Console.WriteLine("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите координаты второй точки");
Console.WriteLine("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y2: ");
int y2= Convert.ToInt32(Console.ReadLine());

double ABDistance(int xc1, int yc1, int xc2, int yc2)
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1);
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
}

Console.WriteLine(ABDistance(x1, y1, x2, y2));