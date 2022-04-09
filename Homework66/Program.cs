int m = 1;
int n = 15;
int summ = 0;
Recursion(m, n);
void Recursion(int a, int b)
{
    if (a == b + 1) return;
    summ += +a;
    Recursion(a + 1, b);
}
Console.WriteLine(summ);