List<int> numbers = new List<int>();
string input;

Console.WriteLine("Enter numbers (Type 'exit' to quit):");

while (true)
{
    Console.Write("Number: ");
    input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    if (int.TryParse(input, out int number))
    {
        numbers.Add(number);
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

if (numbers.Count > 0)
{
    double average = numbers.Average();
    numbers.Sort();

    Console.WriteLine("\nSorted numbers:");
    Console.WriteLine(string.Join(", ", numbers));
    Console.WriteLine($"Average: {average:F2}");
}
else
{
    Console.WriteLine("No valid numbers were entered.");
}