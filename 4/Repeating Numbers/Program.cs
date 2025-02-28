int[] array = { 5, 3, 7, 3, 9, 5, 3, 1, 5, 7, 8 };
bool[] visited = new bool[array.Length];

Console.WriteLine("Duplicate elements:");
for (int i = 0; i < array.Length; i++)
{
    if (visited[i]) continue;

    int count = 1;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            visited[j] = true;
            count++;
        }
    }

    if (count > 1)
        Console.WriteLine($"{array[i]} ({count} times)");
}