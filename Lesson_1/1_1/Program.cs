﻿// Моя вторая программка
// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.
Console.Write("Введите первое целое число: ");
int  a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int  b = int.Parse(Console.ReadLine()!);
if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");    
}