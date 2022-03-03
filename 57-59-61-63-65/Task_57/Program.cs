// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

int[,] fillArr = FillArray();
PrintArray(fillArr);

Console.WriteLine("==================================");

int[,] maxMin = MaxMinArray(fillArr);
PrintArray(maxMin);

int[,] FillArray()                                           // Заполняем массив числами
{
    int[,] array = new int[5, 5];
    Random num = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int e = 0; e < array.GetLength(1); e++)
        {
            array[i, e] = num.Next(1, 26);
        }
    }
    return array;
}

void PrintArray(int[,] arr)                                  // Выводим массив на экран
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int e = 0; e < arr.GetLength(1); e++)
        {
            Console.Write($"{arr[i, e]} ○");
        }
        Console.WriteLine();
    }
}

int[,] MaxMinArray(int[,] array)                             // Производим сортировку массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int item;                                            // Используем SearchBubble
        for (int j = 0; j < array.GetLength(1); j++)         // Проходимся по столбикам
        {
            for (int e = 0; e < array.GetLength(1) - 1; e++)
            {
                if (array[j, e] < array[j, e + 1])          // Сортируем от большего к меньшему (по убыванию)
                {
                    item = array[j, e];                     // Задаем в переменную 1 элемент массива 
                    array[j, e] = array[j, e + 1];          // Присваеваем 1 элементу массива значение 2 элемента массива
                    array[j, e + 1] = item;                 // 2 элементу массива присваиваем значение 1 элемента массива 
                }
            }
        }
    }
    return array;
}
