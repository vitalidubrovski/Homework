void FillaArray (int [] collection)
{
    Random rand = new Random();
    for(int i = 0; i < collection.Length; i++)
    {
        collection[i] = rand.Next(-20, 30);
    }
}
void PrintArray (int [] col)
{
    Console.WriteLine("Вывод массива:");
    for(int i = 0; i < col.Length; i++)
    {
        Console.Write($"{col[i]}|");
    }
    Console.WriteLine();
}

void SortArray (int [] collection)
{
    for(int i = 0; i < collection.Length - 1; i++)
    {
        int minValue = i;
        for(int j = i + 1; j < collection.Length; j++)
        {
            if(Math.Abs(collection[j]) < Math.Abs(collection [minValue])) minValue = j;
        }
        int temp = collection[i];
        collection [i] = collection [minValue];
        collection [minValue] = temp;
    }
}
int [] array = new int [8];
FillaArray(array);
PrintArray(array);
SortArray(array);
Console.WriteLine("Сортировка массива: ");
PrintArray(array);