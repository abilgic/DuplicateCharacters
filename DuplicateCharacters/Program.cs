string str = "happy";

var dict = new Dictionary<char, int>();

for (int i = 0; i < str.Length; i++)
{
    if (dict.ContainsKey(str[i]))
    {
        dict[str[i]]++;
    }
    else
    {
        dict[str[i]] = 1;
    }
}

foreach (var item in dict)
{
    if (item.Value >= 2)
    {
        Console.Write(item.Key);
    }
}
