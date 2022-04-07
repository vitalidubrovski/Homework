int m = 3;
int n = 3;
int[,] matrixA = new int[m, n];
int[,] matrixB = new int[m, n];
FillMatrix(matrixA);
Console.WriteLine("Вывод первой матрицы");
PrintMatrix(matrixA);
FillMatrix(matrixB);
Console.WriteLine("Вывод второй матрицы");
PrintMatrix(matrixB);
int[,] result = new int[m, n];
MatrixProduct();
PrintMatrix(result);

void FillMatrix(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MatrixProduct()
{
    if (m != n)
    {
        Console.WriteLine("Нельзя вычислить произведение!");
    }
    for (int i = 0; i < m; ++i) // каждая строка A
        for (int j = 0; j < n; ++j) // каждый столбец B
            for (int k = 0; k < n; ++k)
                result[i, j] += matrixA[i, k] * matrixB[k, j];
    return;
}