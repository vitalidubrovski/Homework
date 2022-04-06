int rows = 2;
int columns = 6;
int[,] matrix = new int[rows, columns];

FillMatrix();
PrintMatrix();
SummDiffMatrix();

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
void SummDiffMatrix()
{
    int[] arraySumm = new int[columns]; // Массив для хранения суммы
    for (int i = 0; i < rows; i++)
    {
        int summ = 0;
        for (int j = 0; j < columns; j++)
        {
            summ += matrix[i, j];
        }
        arraySumm[i] = summ;
    }
    int min = 0; // Индекс строки с минимальным значением суммы
    for (int j = 0; j < columns; j++)
    {
        if (arraySumm[j] < arraySumm[min])
        {
            min = j;
        }
    }
    Console.WriteLine("Номер строки " + min);

}