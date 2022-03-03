// 61. Найти произведение двух матриц

int col = 10;
int[] arrayFirst = new int[col];
int[] arraySecond = new int[col];

int[] firstAr = FillArray(arrayFirst);
int[] secondAr = FillArray(arraySecond);
PrintArray(firstAr);
PrintArray(secondAr);

Console.WriteLine("==========================================================================");

int[] sumArray = SumArray(firstAr, secondAr);
PrintArray(sumArray);

int[] FillArray(int[] arr)
{
    var num = new Random();
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] = num.Next(1, 10);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ○");
    }
    Console.WriteLine();
}

int[] SumArray(int[] arrOne, int[] arrTwo)
{
    int[] sum = new int[col];
    for(int i = 0; i < col; i++)
    {
        sum[i] = arrOne[i] + arrTwo[i];
    }
    return sum;
}
