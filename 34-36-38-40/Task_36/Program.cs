// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];

int[] fillArray = FillArray(array);
Console.WriteLine();
CheckArray(fillArray);


int[] FillArray(int[] arr)
{
    Random num = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = num.Next(100, 1000);
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void CheckArray(int[] item)
{
    int countOne = 0;
    int countTwo = 0;
    for (int i = 0; i < item.Length; i++)
    {
        if (item[i] % 2 == 0) countOne++;
        else countTwo++;
    }
    Console.WriteLine($"Колличество четных чисел = {countOne}");
    Console.WriteLine($"Количество не четных числе = {countTwo}");
}

