// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
int count = -num1;
while (count <= num1)
{
    Console.Write($"{count}, ");
    count++;
}

