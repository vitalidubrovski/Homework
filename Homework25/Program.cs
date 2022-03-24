Console.WriteLine("Введите натуральное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int b = Convert.ToInt32(Console.ReadLine());
if(a != null)
{
    double x = Math.Pow(a, b);
    Console.WriteLine(x);
}
