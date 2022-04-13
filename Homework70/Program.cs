//1. Дано число n. Получите число, записанное в обратном порядке.
Console.WriteLine("Задача 1");
int n = 1000;
Recursion(n);
void Recursion(int number)
{
    int newNum = number % 10;
    Console.Write(newNum);
    number /= 10;

    if (number > 0)
    {
        Recursion(number);
    }
}


//2.Дана монотонная последовательность, в которой каждое натуральное число n
// встречается ровно n раз: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... 
//Дано число m. Выведите первые m членов этой последовательности.
Console.WriteLine();
Console.WriteLine("Задача 2");
int count = 5;
int firstNumber = 1;
Print(count, firstNumber);
void Print(int m, int n)
{
    int limit = (n + 1) * n / 2;

    for (int i = limit - n; i < limit & i < m; i++)
        System.Console.Write($"{n}, ");

    if (limit < m) Print(m, n + 1);
}


//3. Дано натульное число n > 1. 
//Вывести все простые множители данного числа.
Console.WriteLine();
Console.WriteLine("Задача 3");
int number = 12;
int simpleDivizor = 2;
SimpleMultipier(number, simpleDivizor);
void SimpleMultipier(int n, int m)
{
    if (n > 0)
    {
        if (n == m) Console.WriteLine($"{m}. ");
        else if (n % m == 0)
        {
            n /= m;
            Console.WriteLine($"{m}. ");
            SimpleMultipier(n, m);
        }
        else
        {
            SimpleMultipier(n, ++m);
        }
    }
}