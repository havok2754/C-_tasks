// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите колличество вводимых чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write($"A[{i + 1}] = ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

int PozDig(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        // int count = 0;
        if (array[i] > 0) count++;
        
    }
    return count;
}
int result = PozDig(arr);
Console.WriteLine($"Вы ввели {result} числа, которые больше 0");
