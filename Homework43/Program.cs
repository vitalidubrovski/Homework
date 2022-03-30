Console.WriteLine("Введите координату А для отрезка AB");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введитн координату B для отрезка AB");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату С для отрезка CD");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату D для отрезка CD");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
x = (b2 - b1) / (k1 - k2); // TODO: y = k1*x+b1
double y = 0;
y = k1 * ((b2 - b1) / (k1 - k2)) + b1; // TODO: y = k2*x+b2
if ((b1 / b2)
    == (k1 / k2))
{
    Console.WriteLine("Прямые не пересекаются");
}
else
Console.WriteLine(x + "|" + y);