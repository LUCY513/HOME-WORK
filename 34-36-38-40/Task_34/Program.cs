// 34. Написать программу замену элементов массива на противоположные

int[] array = new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 };
PrintArray(array);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0) array[i] *= -1;
    else array[i] *= -1; 
        Console.Write($"{array[i]} ");
}
