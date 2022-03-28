Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

void FillArray(int [] collection)
{
    Random rand = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection [i] = rand.Next(100, 400);
    }
}
void PrintArray (int [] coll)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write($"{coll[i]}|");
    }
    Console.WriteLine();
}
void NumberOfEvenArray(int [] collect)
{
    int even_num = 0;
    for (int i = 0; i < collect.Length; i++)
    {
        if (collect[i] % 2 == 0)
        {
            even_num++;
        }
    }
    Console.WriteLine(even_num);
}
int [] array = new int [20];
FillArray (array);
PrintArray (array);
NumberOfEvenArray(array);
