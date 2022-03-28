Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

void FillArray (double [] collection)
{
    Random rand = new Random ();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.NextDouble()*100;
    }
}
void PrintArray (double [] col)
{
    Console.WriteLine("Вывод массива:");
    for(int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]}|");
    }
    Console.WriteLine();
}
void FindMaxMinArray (double [] coll)
{
    double maxValue = 0;
    double minValue = 0;
    double diff = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        maxValue = coll.Max<double>();
        minValue = coll.Min<double>();
    }
    diff = maxValue - minValue;
    Console.WriteLine(diff);
}
double [] array = new double [10];
FillArray(array);
PrintArray(array);
FindMaxMinArray(array);
