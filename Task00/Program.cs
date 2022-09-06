// Задача 0. Напишите программу, которая на вход
// 1. принимает число 
// 2. и выдаёт его квадрат (число
// умноженное на само себя).  
// 3. вывод результата  

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49  
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");

