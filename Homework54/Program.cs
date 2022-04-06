int rows = 4;
int columns = 4;
int[,] matrix = new int[rows, columns];

void FillMatrix()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintMatrix()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}|");
        }
        Console.WriteLine();
    }
}

void SortMatrix()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < rows; k++)
            {
                for (int m = 0; m < columns; m++)
                {
                    if (matrix[i, j] > matrix[k, m])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[k, m];
                        matrix[k, m] = temp;
                    }
                }
            }
        }
    }
}


FillMatrix();
PrintMatrix();
SortMatrix();
Console.WriteLine("Сортировка: ");
PrintMatrix();
