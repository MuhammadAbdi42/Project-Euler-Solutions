int numberWithBiggestChain = 0;
double biggestChain = 0;
Dictionary<double, double> numbersChain = new Dictionary<double, double> { { 1, 1 }, { 2, 2 }, { 4, 3 } };
for (int i = 1; i < 1000000; i++)
{
    if (chainNumber(i) > biggestChain)
    {
        biggestChain = chainNumber(i);
        numberWithBiggestChain = i;
    }
}
Console.WriteLine(numberWithBiggestChain);
double chainNumber(int a)
{
    double counter = 0, tempA = a;
    for (; ; )
    {
        if (numbersChain.Keys.Contains(tempA))
        {
            counter += numbersChain[tempA];
            if (!numbersChain.Keys.Contains(a))
            {
                numbersChain.Add(a, counter);
            }
            return counter;
        }
        if (tempA % 2 == 0) tempA /= 2;
        else tempA = 3 * tempA + 1;
        counter++;
    }
}