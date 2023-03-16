// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("«Нахождение большего числа»");
Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);                                                                                                                                                                       
Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} больше, чем {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"{secondNumber} больше, чем {firstNumber}");
}
else
{
    Console.WriteLine($"{firstNumber} и {secondNumber} равны");    
}
Console.WriteLine("Отлично сделано!");