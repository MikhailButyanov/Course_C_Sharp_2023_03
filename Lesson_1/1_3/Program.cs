﻿// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите положительное целое число: ");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a)
{
    Console.Write($"{b} ");
    //b ++; //b = b + 1; 
    b +=1; 
}
Console.WriteLine("Отлично сделано!");
