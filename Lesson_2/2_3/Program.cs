// Язык C#. Задача 3: написать программу.
// Вводим два числа
// Функция принимает на вход через эти числа и 
// выводит текст является ли второе числа кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// "/ 10" убираем последнюю цифру, целочисленное деление, 
// «% 10» получение последней цифры, остаток от деления, кратно
// shift alt A - комментировать выделенный блок

void CheckNum(int num1, int num2)
{
    if (num1 % num2 == 0)
        //Console.WriteLine(num2 + " кратно " + num1);
        Console.WriteLine($"{num2} кратно {num1}");
    else
        Console.WriteLine(num2 + " не кратно " + num1 + ", остаток от деления: " + num1 % num2);
        //Console.WriteLine($"{num2} не кратно {num1}, остаток от деления: {num2 % num1}");
}

Console.WriteLine("Введите два числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
CheckNum(num1, num2);


