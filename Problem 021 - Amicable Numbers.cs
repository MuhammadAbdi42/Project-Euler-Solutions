float sum = 0;
for (int i = 2; i <= 10000; i++)
{
    if (isAmicable(i)) sum += i;
}
Console.WriteLine(sum);
bool isAmicable(int a)
{
    int sumA = 0, sumB = 0;
    for (int i = 1; i <= a / 2; i++)
    {
        if (a % i == 0) sumA += i;
    }
    if (sumA == 1 || sumA == a) return false;
    for (int i = 1; i <= sumA / 2; i++)
    {
        if (sumA % i == 0) sumB += i;
    }
    if (sumB == a)
    {
        Console.WriteLine($"{a} - {sumA}");
        return true;
    }
    else return false;
}