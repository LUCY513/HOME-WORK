// 48. Показать двумерный массив размером  M × N заполненный целыми числами

int[,] fill = FillMatrix();
PrintMatrix(fill);

int[,] FillMatrix()
{
    int[,] matrix = new int[5, 6];
    Random number = new Random();                                // int RandomNum()
    for (int i = 0; i < matrix.GetLength(0); i++)                // {
    {                                                            //     Random number = new Random();
        for (int j = 0; j < matrix.GetLength(1); j++)            //     int number = .Next(1, 10);
        {                                                        //     return number;
            matrix[i, j] = number.Next(1, 10);                   //  }
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}
