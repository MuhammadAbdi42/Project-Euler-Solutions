int answer = 0;
for (int i = 999; i >= 100; i--)
{
    for (int j = 999; j >= 100; j--)
    {
        if (IsPalindrome(i * j))
        {
            if (i * j > answer) answer = i * j;
        }
    }
}
Console.WriteLine(answer);
bool IsPalindrome(int a)
{
    string temp = a.ToString();
    for (int i = 0, j = temp.Length - 1; i < j; i++, j--)
    {
        if (temp[i] != temp[j]) return false;
    }
    return true;
}