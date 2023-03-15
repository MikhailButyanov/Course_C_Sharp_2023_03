// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Нахождение большего числа");
Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье целое число: ");
int c = int.Parse(Console.ReadLine()!);
if (a > b)
{
    if (a > c)
    {
        Console.WriteLine($"max={a}");
    }
    else
    {
        Console.WriteLine($"max={c}"); 
    }
}
else if (b > c)
{
    Console.WriteLine($"max={b}");
}
else
{
    Console.WriteLine($"max={c}");  
}
Console.WriteLine("Хорошая работа!");