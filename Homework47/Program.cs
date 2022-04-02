int rows = 5;
int colums = 5;
double[,] array = new double[rows, colums];
FillArray();
PrintArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = rand.NextDouble() * 5;
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{array[i, j]}|");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}