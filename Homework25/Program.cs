Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int b = Convert.ToInt32(Console.ReadLine());
int pow = 1;
for(int i = 0; i < b; i++)
{
    pow *= a;
}
Console.WriteLine(pow);