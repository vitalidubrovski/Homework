int[,,] array = new int[1, 2, 3];
int number = 10;
int i, j, k;
FillMatrix();
Console.WriteLine("Вывод массива");
PrintMatrix();
void FillMatrix()
{
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }
}

void PrintMatrix()
{
    int index = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("Элемент " + $"{array[i, j, k]}  c индексом  {index++}|");
            }
        }
    }
}
