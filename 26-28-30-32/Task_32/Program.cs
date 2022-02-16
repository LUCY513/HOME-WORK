//32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// где подвох???)

int[] arrayNullOne = new int[8];

void FillArray()
{
    Random num =  new Random();
    for(int i = 0; i < arrayNullOne.Length; i++)
    {
        arrayNullOne[i] = num.Next(0, 2);
        Console.Write($"{arrayNullOne[i]} ");
    }
}
FillArray();
