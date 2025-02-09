float sum = 0;
for (int i = 1; i < 1000; i++)
{
    if (isDivisableByThreeOrFive(i)) sum += i;
}
Console.WriteLine(sum);
bool isDivisableByThreeOrFive(int a)
{
    if (a % 3 == 0 || a % 5 == 0)
    {
        Console.WriteLine(a);
        return true;
    }
    else return false;
}