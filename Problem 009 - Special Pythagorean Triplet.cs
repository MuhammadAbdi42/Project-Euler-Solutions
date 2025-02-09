bool found = false;
for (int a = 1; ; a++)
{
    if (found) break;
    for (int b = 1; ; b++)
    {
        if (a + b == 1000 || found) break;
        for (int c = 1; ; c++)
        {
            if (a + b + c > 1000 || found) break;
            if (a + b + c == 1000 && a * a + b * b == c * c)
            {
                Console.WriteLine(a * b * c);
                found = true;
            }
        }
    }
}