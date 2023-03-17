﻿/* GB Язык C#. Задача 1: 
Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
Используя операторы "/" и "%".
Добавить проверку на трёхзначное число.
456 -> 5
782 -> 8
918 -> 1 */
// "shift alt A" - комментировать выделенный блок

void Main(int num)
{
    if (num < 100 || num > 999) // "||" логическое ИЛИ, «или то, или другое, или оба»
        Console.WriteLine("Ошибка: введенное число не является трёхзначным.");
    else 
        Console.WriteLine($"Вторая цифра введенного числа: {((num / 10) % 10)}");
}

Console.WriteLine("Введите целое трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
Main(num);