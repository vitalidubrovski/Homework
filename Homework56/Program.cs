int rows = 4;
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
    int[] arraySumm = new int[rows]; // Массив для хранения суммы
    for (int i = 0; i < rows; i++)
    {
        int summ = 0;
        for (int j = 0; j < columns; j++)
        {
            summ += matrix[i, j];
        }
        arraySumm[i] = summ;
        Console.WriteLine(summ);
    }
    
    int min = 0;
    for(int k = 1; k < arraySumm.Length; k++)
    {
        if(arraySumm[k] == arraySumm[min])
        {
            Console.WriteLine("Суммы равны");
        }
        if (arraySumm[k] < arraySumm[min])
        {
            min = k;
        }
    }
    Console.WriteLine("Номер строки с наименьшей суммой " +(min +1));


}