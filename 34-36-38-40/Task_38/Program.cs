// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[11];
int[] fillArray = FillArray(array);
Console.WriteLine();
int sum = 0;

int[] FillArray(int[] arr)       // Метод который заполняет массив случайными числами и печатает его  
{
    Random number = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = number.Next(1, 51);
        Console.Write($"{i}. {arr[i]}    ");
    }
    return arr;
}

for (int i = 0; i < array.Length; i++)     // Создаем цикл перебора массива 
{
    if (i % 2 != 0)            // Задаем условие на нахождение не четной позиции элемента 
    {
        sum += array[i];
        Console.WriteLine($"index {i}. {array[i]} = {sum}");
    }
    else Console.Write("");
}
Console.WriteLine($"Сумма элементов массива с нечетной позицией = {sum}");
