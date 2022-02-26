// 50. В двумерном массиве N × K заменить четные элементы на противоположные


int[,] fillMat = FillMatrix();
PrintMatrix(fillMat);
Console.WriteLine();
int[,] RepMat = ReplaceMatrix(fillMat);
PrintMatrix(RepMat);


int[,] FillMatrix()
{
    Random number = new Random();
    int[,] array = new int[5, 6];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = number.Next(1, 10);
        }
    }
    return array;
}

int[,] ReplaceMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            if (mat[i, j] % 2 != 0) mat[i, j] *= -1;
            else mat[i, j] *= 1;
        }
    }
    return mat;
}

void PrintMatrix(int[,] matrix)
{
    for(int i= 0; i<matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ○");
        }
        Console.WriteLine();
    }
}