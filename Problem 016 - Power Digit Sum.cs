List<double> digits = new List<Double> { 1 };
double answer = 0;
for (int i = 1; i <= 1000; i++)
{
    for (int j = 0; ; j++)
    {
        if (j == digits.Count) break;
        digits[j] *= 2;
    }
    for (int j = 0; ; j++)
    {
        if (j == digits.Count) break;
        if (digits[j] >= 10)
        {
            if (j != digits.Count - 1) digits[j + 1] += Math.Truncate(digits[j] / 10);
            else digits.Add(Math.Truncate(digits[j] / 10));
            digits[j] -= 10;
        }
        foreach (double num in digits)
        {
            if (num >= 10) continue;
            break;
        }
    }
}
for (int i = 0; i < digits.Count; i++) answer += digits[i];
Console.WriteLine(answer);