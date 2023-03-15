// Знакомство с языками программирования (семинары)
// Урок 1. Знакомство с языком программирования С#
// Задача 4: Напишите программу, 
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("«Нахождение большего числа»");
Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье целое число: ");
int thirdNumber = int.Parse(Console.ReadLine()!);
//if (firstNumber > secondNumber)
//{
//    if (firstNumber > thirdNumber)
//    {
//        Console.WriteLine($"Максимальное число:={firstNumber}");
//    }
//    else
//    {
//        Console.WriteLine($"Максимальное число:={thirdNumber}"); 
//    }
//}
//else if (secondNumber > thirdNumber)
//{
//    Console.WriteLine($"Максимальное число:={secondNumber}");
//}
//else
//{
//    Console.WriteLine($"Максимальное число:={thirdNumber}");  
//}

// Вариант покороче:
int maxNumber = firstNumber;
if (secondNumber > maxNumber)
{
    maxNumber = secondNumber;
}
if (thirdNumber > maxNumber)
{
    maxNumber = thirdNumber;
}
Console.WriteLine($"Максимальное число:= {maxNumber}");
Console.WriteLine("Хорошая работа!");