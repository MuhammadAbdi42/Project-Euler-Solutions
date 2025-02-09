// The file represented as `d:\text.txt` is extracted from problem page.

using System;
using System.IO;
int[,] nums = new int[15, 15];
string path = @"d:\text.txt";
using (StreamReader sr = File.OpenText(path))
{
    string s, temp = "";
    for (int i = 0; i < 15; i++)
    {
        s = sr.ReadLine();
        for (int j = 0; j <= i; j++)
        {
            temp = "";
            temp += s[j * 3].ToString() + s[(j * 3) + 1].ToString();
            nums[i, j] = int.Parse(temp);
        }
    }
}
for (int i = 13; i >= 0; i--)
{
    for (int j = 0; j <= i; j++)
    {
        if (nums[i + 1, j] > nums[i + 1, j + 1]) nums[i, j] += nums[i + 1, j];
        else nums[i, j] += nums[i + 1, j + 1];
    }
}
Console.WriteLine(nums[0, 0]);