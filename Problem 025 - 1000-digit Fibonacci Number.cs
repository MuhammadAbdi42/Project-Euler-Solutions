List<double> fib1 = new List<double> { 1 };
List<double> fib2 = new List<double> { 1 };
List<double> fib3 = new();
for (int i = 1; ; i++
{
    if (fib1.Count >= 1000)
    {
        Console.WriteLine(i);
        break;
    }
    for (int j = 0, k = 0; ; j++, k++)
    {
        if (j >= fib1.Count && k >= fib2.Count) break;
        double a = 0;
        int largerIndex = j >= k ? j : k;
        if (j < fib1.Count) a += fib1[j];
        if (k < fib2.Count) a += fib2[k];
        if (largerIndex >= fib3.Count) fib3.Add(a);
        else fib3[largerIndex] = a;
    }
    for (int j = 0; ; j++)
    {
        if (j == fib3.Count) break;
        if (fib3[j] >= 10)
        {
            double tempDigit = fib3[j] % 10;
            if (j != fib3.Count - 1)
            {
                fib3[j + 1] += Math.Truncate(fib3[j] / 10);
                fib3[j] = tempDigit;
            }
            else
            {
                fib3.Add(Math.Truncate(fib3[j] / 10));
                fib3[j] = tempDigit;
            }
        }
    }
    fib1 = fib2.ToList();
    fib2 = fib3.ToList();
}