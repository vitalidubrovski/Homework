int rows = 5;
int columns = 5;
int[,] array = new int[rows, columns];
FillArray();
PrintArray();
FindArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(1, 20);
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
void FindArray()
{
    Console.WriteLine("Введите порядковый номер для строк");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите порядковый номер для столбцов");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (firstNumber <= array.GetLength(0) -1 && secondNumber <= array.GetLength(1) -1)
            {
                Console.WriteLine(array[firstNumber, secondNumber]);
                return;
            }
            else
            {
                Console.WriteLine("Не существует");
                return;
            }

        }
    }
}