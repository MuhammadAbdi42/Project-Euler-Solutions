double sumOfPrimes = 0;
for (int i = 2; i < 2000000; i++)
{
    if (isPrime(i)) sumOfPrimes += i;
}
Console.WriteLine(sumOfPrimes);
bool isPrime(double a)
{
    for (double i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0) return false;
    }
    return true;
}