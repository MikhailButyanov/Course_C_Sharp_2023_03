// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("«Нахождение большего числа»");
Console.Write("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.Write($"max={a}"); // Console.WriteLine(a);
}
else
{
    Console.WriteLine($"max={b}");    // Console.WriteLine(b); 
}
Console.WriteLine("Отлично сделано!");