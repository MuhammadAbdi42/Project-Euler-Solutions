string[] firstDigit = ["One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"];
string[] secondDigit = ["Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];
string[] exceptions = ["Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"];
int final = 0;
for (int i = 1; i <= 1000; i++)
{
    final += stringCharacter(i);
}
Console.WriteLine(final);
int stringCharacter(int a)
{
    string answer = "";
    int fourth = a / 1000;
    int third = (a / 100) % 10;
    int second = (a / 10) % 10;
    int first = a % 10;
    if (fourth != 0) answer += firstDigit[fourth - 1] + "Thousand";
    if (fourth != 0 && (third != 0 || second != 0 || first != 0)) answer += "And";
    if (third != 0) answer += firstDigit[third - 1] + "Hundred";
    if (third != 0 && (second != 0 || first != 0)) answer += "And";
    if (second == 1 && first != 0) answer += exceptions[first - 1];
    else
    {
        if (second != 0) answer += secondDigit[second - 1];
        if (first != 0) answer += firstDigit[first - 1];
    }
    return answer.Length;
}
Console.ReadLine();