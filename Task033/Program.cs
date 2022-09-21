// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.WriteLine("Введите чиcло для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] CreaateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = size - 1; i >= 0; i--)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
     }
    Console.Write("]");
}

bool Comparison(int[] array, int num)
{
   bool exist = false;
    for (int i = 0; i < array.Length; i++)
    {
         if( num == array[i])
         {
            exist = true;
            break;
         } //Console.WriteLine($"Число {num} присутствует в массиве");
        // else Console.WriteLine($"Число {num} не присутствует в массиве");
        
    }
    return exist;
}
int[] arr = CreaateArrayRndInt(6, -3, 3);
PrintArray(arr);
Console.WriteLine();
bool result = Comparison(arr, number);
if (result == true) Console.WriteLine($"Число {number} присутствует в массиве");
else Console.WriteLine($"Число {number} не присутствует в массиве");
