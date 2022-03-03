// 65. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
int S = 5;

int[,] fillArr = FillArray();
int[,] spiralArr = Spiral(fillArr);
PrintArray(spiralArr);

int[,] FillArray()
{
    int[,] array = new int[S, S];
    Random num = new Random();
    for (int i = 0; i < S; i++)
    {
        for (int j = 0; j < S; j++)
        {
            array[i, j] = num.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < S; i++)
    {
        for (int j = 0; j < S; j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Spiral(int[,] array)
{
    int num = 1;
    for (int sector = 0; sector < S - sector; sector++)
    {
        for (int i = 0 + sector; i < S - sector; i++)           // Строка
        {
            array[0 + sector, i] = num;
            num++;
        }
        num--;
        for (int j = 0 + sector; j < S - sector; j++)           // Столбик 
        {
            array[j, S - 1 - sector] = num;
            num++;
        }
        num--;
        for (int k = S - 1 - sector; k >= 0 + sector; k--)           // Строка
        {
            array[S - 1 - sector, k] = num;
            num++;
        }
        num--;
        for (int e = S - 1 - sector; e >= 1 + sector; e--)            // Столбик
        {
            array[e, 0 + sector] = num;
            num++;
        }
    }
    return array;
}
