//An array of [Year, Month, Day] starting from 1 Jan 1900 (Monday = 3) to 31 Dec 2000 (Non-existing days will be 0)
int[,,] days = new int[101, 12, 31];
days[0, 0, 0] = 3;
for (int i = 0; i < 101; i++)
{
    for (int j = 0; j < 12; j++)
    {
        for (int k = 0; k < 31; k++)
        {
            //Skipping 1 Jan 1990
            if (i == 0 && j == 0 && k == 0) continue;
            //Jumping to next month when needed
            if (k == 30 && (j == 3 || j == 5 || j == 8 || j == 10))
            {
                days[i, j, k] = 0;
                break;
            }
            if (k == 28 && j == 1)
            {
                if ((i + 1900) % 4 == 0)
                {
                    if ((i + 1900) % 100 == 0 && (i + 1900) % 400 != 0)
                    {
                        days[i, j, 28] = 0;
                        days[i, j, 29] = 0;
                        days[i, j, 30] = 0;
                        break;
                    }
                    else
                    {
                        days[i, j, 28] = days[i, j, 27] + 1;
                        if (days[i, j, k] == 8) days[i, j, k] = 1;
                        days[i, j, 29] = 0;
                        days[i, j, 30] = 0;
                        break;
                    }
                }
                else
                {
                    days[i, j, 28] = 0;
                    days[i, j, 29] = 0;
                    days[i, j, 30] = 0;
                    break;
                }
            }
            //Defining Not First Days
            if (k != 0)
            {
                days[i, j, k] = days[i, j, k - 1] + 1;
                if (days[i, j, k] == 8) days[i, j, k] = 1;
            }
            //Defining First Days
            if (k == 0)
            {
                if (j == 0)
                {
                    days[i, j, k] = days[i - 1, 11, 30] + 1;
                    if (days[i, j, k] == 8) days[i, j, k] = 1;
                }
                if (j == 1 || j == 3 || j == 5 || j == 7 || j == 8 || j == 10)
                {
                    days[i, j, k] = days[i, j - 1, 30] + 1;
                    if (days[i, j, k] == 8) days[i, j, k] = 1;
                }
                if (j == 2)
                {
                    if (days[i, 1, 28] != 0) days[i, j, k] = days[i, 1, 28] + 1;
                    else days[i, j, k] = days[i, 1, 27] + 1;
                    if (days[i, j, k] == 8) days[i, j, k] = 1;
                }
                if (j == 4 || j == 6 || j == 9 || j == 11)
                {
                    days[i, j, k] = days[i, j - 1, 29] + 1;
                    if (days[i, j, k] == 8) days[i, j, k] = 1;
                }
            }
        }
    }
}
//Getting Sundays on the first of the month
int answer = 0;
for (int i = 1; i < 101; i++)
{
    for (int j = 0; j < 12; j++)
    {
        if (days[i, j, 0] == 2) answer++;
    }
}
Console.WriteLine(answer);