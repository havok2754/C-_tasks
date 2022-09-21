// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int Stepen(int num)
// {
//     int a = num1;

//     for (int i = 2; i <= num2 ; i++)
//      {
//         if (num2 == 0) Console.WriteLine($"Число123 {num1} в степени {num2}  = {1}");
//         else   if (num2 == 1) Console.WriteLine($"Числоrt564 {num1} в степени {num2}  = {num1}");
//         else
//         a = a * num1;
//     }
//     return a;
// }
// int sumNumber = Stepen(num1);

// Console.WriteLine($"Число {num1} в степени {num2}  = {sumNumber}");


Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 if (num2 == 0) Console.WriteLine($"Число {num1} в степени {num2}  = 1");
        else   if (num2 == 1) Console.WriteLine($"Число {num1} в степени {num2}  = {num1}");
        else
        {

int Stepen(int num)
{
    int a = num1;
    

    for (int i = 2; i <= num2 ; i++)
     {
        if (num2 == 0) return a = 1;
        else   if (num2 == 1) return a = a;
        else
        a = a * num1;
    }
    return a;
}
        int stepennum1 = Stepen(num1);
        Console.WriteLine($"Число {num1} в степени {num2}  = {stepennum1}");
        }