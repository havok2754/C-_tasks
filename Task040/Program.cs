// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 + num3) Console.WriteLine("Такой треугольник не возможен ");
else if (num2 > num1 + num3) Console.WriteLine("Такой треугольник не возможен ");
else if (num3 > num2 + num1) Console.WriteLine("Такой треугольник не возможен ");
else Console.WriteLine("Такой треугольник может быть");