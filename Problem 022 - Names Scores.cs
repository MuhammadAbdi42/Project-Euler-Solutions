string path = @"d:\names.txt", input = "";
using (StreamReader sr = File.OpenText(path)) input += sr.ReadLine();
List<string> names = new();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '"')
    {
        string temp = "";
        for (int j = i + 1; ; j++)
        {
            if (input[j] == '"')
            {
                i = j;
                names.Add(temp);
                break;
            }
            else temp += input[j].ToString();
        }
    }
}
names.Sort();
double answer = 0;
for (int i = 0; i < names.Count; i++)
{
    int temp = 0;
    for (int j = 0; j < names[i].Length; j++)
    {
        temp += names[i][j] - 64;
    }
}
Console.WriteLine(answer);