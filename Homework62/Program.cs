int n = 4;
int spiral = 1;
int[,] matrix = new int[n, n];
FillMatrix();
PrintMatrix();
int i, j;
void FillMatrix()
{
    for (j = 0, i = 0; j < n; j++)
    {
        matrix[i, j] = spiral;
        spiral++;
    }
    spiral--;

    for (i = 0, j = n - 1; i < n; i++)
    {
        matrix[i, j] = spiral;
        spiral++;
    }
    spiral--;

    for (j = n - 1, i = n - 1; j >= 0; j--)
    {
        matrix[i, j] = spiral;
        spiral++;
    }
    spiral--;
    for (i = n - 1, j = 0; i >= 1; i--)
    {
        matrix[i, j] = spiral;
        spiral++;
    }

    for (i = 1, j = 1; i < n - 1; i++)
    {
        matrix[j, i] = spiral;
        spiral++;
    }
    for (i = n - 2, j = n - 2; i >= 1; i--)
    {
        matrix[j, i] = spiral;
        spiral++;
    }
}
void PrintMatrix()
{
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < n; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
