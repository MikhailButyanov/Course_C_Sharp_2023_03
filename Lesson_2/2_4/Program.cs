﻿/* Язык C#. Задача 4: написать программу,
используя функцию void, 
которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. */
// shift alt A - комментировать выделенный блок

void Div(int num)
{
    if (num % 7 == 0 && num % 23 == 0) //полная проверка
        Console.WriteLine("Число кратно 7 и 23");
    else
        Console.WriteLine("Число не кратно 7 и 23");
}

Console.WriteLine("Введите целое число: ");
int num = int.Parse(Console.ReadLine()!);
Div(num);