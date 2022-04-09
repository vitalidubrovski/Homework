int m = 1;
int n = 33;
Recursion(m, n);
void Recursion(int a, int b)
{
    if (a == b + 1) return;
    {
        if (a % 3 == 0)
        {
            Console.Write(a + " ");
        }

    }
    Recursion(a + 1, n);
}