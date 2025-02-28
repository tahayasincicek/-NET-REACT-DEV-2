List<int> numbers = new List<int> { 5, 12, 8, 20, 15, 3, 10, 25, 7 };

numbers.RemoveAll(n => n < 10);

Console.WriteLine("Numbers 10 and above:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}