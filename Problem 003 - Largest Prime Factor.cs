double num = 600851475143;
for (double i = Math.Truncate(Math.Sqrt(num)) + 1; i > 1; i--)
{
    if (num % i == 0)
    {
        if (isPrime(i))
        {
            Console.WriteLine(i);
            break;
        }
    }
}
bool isPrime(double a)
{
    for (double i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}