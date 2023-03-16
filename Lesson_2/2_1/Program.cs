// Задача 1
// принимаем на вход трёхзначное число, выводим последнюю цифру этого числа
int TakeNum(int num)
{ //тело функции
    Console.WriteLine(num);
    return num % 10;
} //тело функции


int result = TakeNum(new Random().Next(100, 1000));
// int num = new Random().Next(100, 1000); //выдаёт от 100 до 999

Console.WriteLine(result);
//Console.WriteLine(num % 10);
// shift alt A - комментировать выделенный блок
