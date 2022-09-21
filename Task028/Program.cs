// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

int MultNumber(int num)
{
    int mult = 1;

    for (int i = 1; i <= num ; i++)
    {
        mult = mult * i;
    }
    return mult;
}
int multNumber = MultNumber(number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {multNumber}");