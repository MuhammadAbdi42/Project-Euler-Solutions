List<double> digits = new List<double> { 1 };
for (int i = 1; i <= 100; i++)
{
    for (int j = 0; j < digits.Count; j++)
    {
        digits[j] *= i;
    }
    for (int j = 0; ; j++)
    {
        if (j == digits.Count) break;
        if (digits[j] >= 10)
        {
            double tempDigit = digits[j] % 10;
            if (j != digits.Count - 1)
            {
                digits[j + 1] += Math.Truncate(digits[j] / 10);
                digits[j] = tempDigit;
            }
            else
            {
                digits.Add(Math.Truncate(digits[j] / 10));
                digits[j] = tempDigit;
            }
        }
    }
}
double answer = 0;
for (int i = digits.Count - 1; i >= 0; i--) answer += digits[i];
Console.WriteLine(answer);