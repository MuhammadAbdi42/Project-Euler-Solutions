for (double i = 2, primeCounter = 0; primeCounter < 10001; i++)
{
    if (isPrime(i)) primeCounter++;
    if (primeCounter == 10001) Console.WriteLine(i);
}
bool isPrime(double a)
{
    for (double i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0) return false;
    }
    return true;
}