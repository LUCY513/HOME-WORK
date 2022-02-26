// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] filMat = FillMatrix();
PrintMatrix(filMat);
Console.WriteLine();
int[,] multi = MultiChet(filMat);
PrintMatrix(multi);

int[,] FillMatrix()
{
    Random num = new Random();
    int[,] matrix = new int[5, 6];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = num.Next(1, 10);
        }
    }
    return matrix;
}

int[,] MultiChet(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for( int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ○");
        }
        Console.WriteLine();
    }
}