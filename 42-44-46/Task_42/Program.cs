// 42. Определить сколько чисел больше 0 введено с клавиатуры

int[] x = ArrayNum();
PrintArray(x);
Console.WriteLine();
CheckArray(x);

int InPut()
{
    Console.Write($"Введите число: ");
    string sqwert = Console.ReadLine();
    int.TryParse(sqwert, out int num);
    return num;
}

int[] ArrayNum()
{
    int[] array = new int[10];

    for (int i = 0; i < 10; i++)
    {
        array[i] += InPut();
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void CheckArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");  
}