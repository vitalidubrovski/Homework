//Задача 1. На вход подуются два числа n и m, такие, что n<m. 
//Заполните массив случайными числами из промежутка [n, m].
Console.WriteLine("Задача 1");
Console.WriteLine();

int n = 1;
int m = 10;
int[] array = new int[m];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(n, m);
    }
}
void PrintArray(int[] collection)
{
    for (int j = 0; j < collection.Length; j++)
    {
        Console.Write($"{collection[j]}| ");
    }
    Console.WriteLine();
}


//Двумерный массив заполнен случайными натуральными числами от 1 до 10. 
//Найдите количество элементов, значение которых больше 5, и их сумму
Console.WriteLine();
Console.WriteLine("Задача 2");
int rows = 3;
int columns = 3;
int[,] matrix = new int[rows, columns];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int sum = SummElements(matrix);
Console.WriteLine($"Summ = {sum}");


void FillMatrix(int[,] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write($"{array[k, m]}| ");
        }
        Console.WriteLine();
    }
}

int SummElements(int[,] collection)
{
    int moreNumber = 5;// > 5
    int summ = 0;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (collection[i, j] > moreNumber)
            {
                summ += collection[i, j];
            }
        }
    }
    return summ;
}

Console.WriteLine();
Console.WriteLine("Задча 3");
//Напишите рекурсивный метод, 
//который принимает номер года и определяет, является ли он високосным или нет.

int year = 1984;
LeapYear(year);
void LeapYear(int date)
{
    if (date % 4 == 0 && (date % 100 != 00 || date % 400 == 0))
    {
        Console.WriteLine("Является");
    }
    else if (date == 0)
    {
        LeapYear(date);
    }
    else Console.WriteLine("Не является");

}