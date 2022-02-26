// 54. В матрице чисел найти сумму элементов главной диагонали

int[,] filMat = FillMatrix();
PrintMatrix(filMat);
Console.WriteLine();
Console.WriteLine($"Сумма главной диагонали = {SumDiag(filMat)}");


int[,] FillMatrix()
{
    Random num = new Random();
    int[,] matrix = new int[5, 5];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = num.Next(1, 10);
        }
    }
    return matrix;
}

int SumDiag(int[,] mat)
{
    int result = 0;
    for(int i = 0; i < mat.GetLength(0); i++)
    {
        for(int j = 0; j < mat.GetLength(1); j++)
        {
            if(i == j) result += mat[i, j]; 
        }
    }
    return result;
}

void PrintMatrix(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}