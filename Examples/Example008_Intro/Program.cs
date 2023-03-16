// Функция Max и массивы
//int[]array = {3, 24, 54, 45, 456}
//int[]array = [5] 5 индекс
//int[]array = [5]{3, 24, 54, 45, 456}
Console.WriteLine("Hello, World!");
void FillArray(int[] collection) //void метод - ничего не возвращает
// и оператор return не используется
{
    int length =collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count =col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }    
}

int[] array = new int[10]; //создаётся и заполняется нулями

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //типа элемент не найден
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; //выход после первого нахождения
        }
        index++;
    }
    return position;
}


FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);

//int Max(int arg1, int arg2, int arg3)
//{
//    int result = arg1;
//    if(arg2 > result) result = arg2;
//    if(arg3 > result) result = arg3;
//    return result;
//}

//int a1 = 1;
//int b1 = 6;
//int c1 = 9;

//int[] array = {3, 24, 54, 45, 456, 345, 23, 553, 45};
//int n = array.Length;
//int max  = Max(
//    Max(array[0], array[1], array[2]), 
//    Max(array[3], array[4], array[5]), 
//    Max(array[6], array[7], array[8]));
//Console.WriteLine(max);

