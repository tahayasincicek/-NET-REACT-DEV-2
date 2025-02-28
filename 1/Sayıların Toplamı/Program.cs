// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;
number = Math.Abs(number); //takes the absolute value of negative numbers


for (; number > 0; number /= 10)
{
    sum += number % 10;
}
Console.WriteLine("Sum of the numbers: " + sum);
