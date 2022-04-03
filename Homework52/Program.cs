int rows = 2;
int columns = 3;
int[,] array = new int[rows, columns];
FillArray();
PrintArray();
AverageArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]}|");
        }
        Console.WriteLine();
    }
}
void AverageArray()
{
    double summ = 0;
    double average = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            summ += array[i, j];
            average = summ / array.GetLength(1);
        }
    }
    Console.WriteLine(average);
}