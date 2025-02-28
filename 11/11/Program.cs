List<int> grades = new List<int> { 45, 78, 32, 90, 50, 48, 67, 20 };

for (int i = 0; i < grades.Count; i++)
{
    if (grades[i] < 50)
    {
        grades[i] = 50;
    }
}

Console.WriteLine("Updated grades:");
foreach (int grade in grades)
{
    Console.Write(grade + " ");
}
