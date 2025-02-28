// See https://aka.ms/new-console-template for more information

while (true)
{

    Console.WriteLine("Enter a number between 10 and 100");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 10 && number <= 100)
    {
        Console.WriteLine("True range");
        break;
    }

    Console.WriteLine("Please enter true number");
}
