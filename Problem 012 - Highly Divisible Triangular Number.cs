List<double> primeNumbers = new List<double> { 2 };
for (int i = 2; ; i++)
{
    double summation = i * (i + 1) / 2;
    if (NumberOfDivisors(summation) > 500)
    {
        Console.WriteLine($"{i}. {summation} -> {NumberOfDivisors(summation)}");
        break;
    }
}
double NumberOfDivisors(double a)
{
    double answer = 1;
    Dictionary<double, double> primeFactorsWithPower = new Dictionary<double, double> { };
    for (double i = 1; i <= a; i++)
    {
        if (isPrime(i))
        {
            double k = 0;
            for (; ; )
            {
                if (a % i != 0) break;
                else
                {
                    k++;
                    a /= i;
                }
            }
            if (k != 0) primeFactorsWithPower.Add(i, k);
        }
    }
    foreach (double primeFactor in primeFactorsWithPower.Keys)
    {
        answer *= primeFactorsWithPower[primeFactor] + 1;
    }
    return answer;
}
bool isPrime(double a)
{
    if (a == 1) return false;
    if (primeNumbers.Contains(a)) return true;
    else
    {
        foreach (double primeNumber in primeNumbers)
        {
            if (a % primeNumber == 0) return false;
        }
        for (double i = primeNumbers[primeNumbers.Count - 1] + 1; i <= Math.Sqrt(a); i++)
        {
            foreach (double primeNumber in primeNumbers)
            {
                if (i % primeNumber == 0)
                {
                    primeNumbers.Add(i);
                    if (a % i == 0) return false;
                }
            }
        }
        primeNumbers.Add(a);
        return true;
    }
}