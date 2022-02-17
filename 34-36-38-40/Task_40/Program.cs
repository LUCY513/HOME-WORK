// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double[]{22.5, 11.5, 6.96, 96.9, 54.2, 8.3, 17.5, 33.3, 44.4, 55.5 };
PrintArray();

double itemMax = Max(array);
double itemMin = Min(array);

Console.Write($"\nРазница между числами:\nmax: {itemMax}\nmin: {itemMin}\nРавна: {itemMax - itemMin}");

void PrintArray()
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}    ");
    }
}

double Max(double[] arrMax)
{
    double max = 0; 
    for(int i = 0; i < arrMax.Length; i++)
    {
        if(arrMax[i] > max) max = arrMax[i];
    }
    //Console.WriteLine(max);
    return max;
}

double Min(double[] arrMin)
{
    double min = arrMin.Length; 
    for(int i = 0; i < arrMin.Length; i++)
    {
        if(arrMin[i] < min) min = arrMin[i];
    }
    //Console.WriteLine(min);
    return min;
}
