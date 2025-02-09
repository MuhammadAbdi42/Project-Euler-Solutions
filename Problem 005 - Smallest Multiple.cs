Dictionary<int, int> primeFactorsWithPower = new Dictionary<int, int> { };
double answer = 1;
for (int i = 2; i <= 20; i++)
{
    for (int j = 2; j <= i; j++)
    {
        if (isPrime(j))
        {
            int k = 0;
            int temp = i;
            for (; ; k++)
            {
                if (temp % j == 0) temp /= j;
                else break;
            }
            if (k != 0)
            {
                if (primeFactorsWithPower.TryGetValue(j, out int tempPower))
                {
                    if (tempPower < k) primeFactorsWithPower[j] = k;
                }
                else
                {
                    primeFactorsWithPower.Add(j, k);
                }
            }
        }
    }
}
foreach (int primeFactor in primeFactorsWithPower.Keys)
{
    answer *= Math.Pow(primeFactor, primeFactorsWithPower[primeFactor]);
}
Console.WriteLine(answer);
bool isPrime(int a)
{
    for (int i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}