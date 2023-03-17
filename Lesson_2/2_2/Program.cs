// Язык C#. Задача 2: 
// вывод случайного числа из [10, 99], выводим наибольшую цифру этого числа
// "/ 10" убираем последнюю цифру, целочисленное деление, 
// «% 10» получение последней цифры, остаток от деления
// shift alt A - комментировать выделенный блок

int MaxNum(int number)
{ //тело функции
    Console.WriteLine(number);
    int firstDigit = number / 10; // "/ 10" убираем последнюю цифру
    int secondDigit = number % 10; // "% 10" получение последней цифры
    if(firstDigit > secondDigit) return firstDigit; //return заканчивает функцию
    return secondDigit;
} //тело функции

int number = new Random().Next(10, 100);
Console.WriteLine($"Сгенерированное число: {number}");
Console.WriteLine($"Наибольшая цифра: {MaxNum(number)}");