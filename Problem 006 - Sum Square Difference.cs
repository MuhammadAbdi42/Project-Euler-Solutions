int squareOfSums = ((1 + 100) * (100) / 2) * ((1 + 100) * (100) / 2);
int sumOfSqaures = 0;
for (int i = 1; i <= 100; i++)
{
    sumOfSqaures += i * i;
}
Console.WriteLine(squareOfSums - sumOfSqaures);