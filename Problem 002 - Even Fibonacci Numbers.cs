List<double> fibNums = new List<double> { 1, 1, 2 };
double sum = 0;
for (int i = 1; ; i++)
{
    if (fib(i) > 4000000) break;
    if (fib(i) % 2 == 0)
    {
        Console.WriteLine($"{i}. {fib(i)}");
        sum += fib(i);
    }
}
Console.WriteLine(sum);
double fib(int i)
{
    if (fibNums.Count - 1 < i)
    {
        fibNums.Add(fibNums[i - 1] + fibNums[i - 2]);
        return fibNums[i];
    }
    return fibNums[i];
}