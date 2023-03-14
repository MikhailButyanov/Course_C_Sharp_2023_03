// Моя первая суперическая программа
Console.Write("Введите целое число: ");
string s = Console.ReadLine()!; //Console.ReadLine() считывает только строки
//! снимает предупреждения
int num = int.Parse(s); // Преобразование string в int
Console.Write("Квадрат вашего числа: ");
Console.WriteLine(num * num); //Арифметические операции невыполняются со строками