Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

void FillArray (int [] collection)
{
    Random rand = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.Next(-100, 100);
    }
}
void PrintArray(int [] collect)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < collect.Length; i++)
    {
        Console.WriteLine($"{collect[i]}|");
    }
    Console.WriteLine();
}
void SumOfOddArray(int [] coll)
{
    int sum_odd = 0;
    for (int i = 1; i < coll.Length; i+=2)
    {
        sum_odd += coll[i];
    }
    Console.WriteLine(sum_odd);
}
int [] array = new int [10];
FillArray(array);
PrintArray(array);
SumOfOddArray(array);