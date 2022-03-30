Console.WriteLine("Введите количество чисел");
int elementCount = Convert.ToInt32(Console.ReadLine());
int[] array = new int[elementCount];
for (int i = 0; i < elementCount; i++)
{
    Console.WriteLine("Введите эти числа через <Enter>");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] collection)
{
    Console.WriteLine("Вывод чисел:");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]}|");
    }
    Console.WriteLine();
}
void Compare(int[] coll)
{
    int count = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}
PrintArray(array);
Compare(array);