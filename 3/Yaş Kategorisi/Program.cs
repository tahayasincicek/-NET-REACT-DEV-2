// See https://aka.ms/new-console-template for more information

Console.Write("Enter the number of people whose age you want to input: ");
int size = int.Parse(Console.ReadLine());
int[] ageList = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write($"Enter {i+1}. age: ");
    ageList[i] = Convert.ToInt32(Console.ReadLine());
}

foreach(int age in ageList)
{
    string category;
   
    if(age>=0 && age <= 12)
    {
        category = "Child";
    }

    else if(age >= 13 && age <= 19)
    {
        category = "Teenager";
    }

    else if(age >= 20 && age <= 64)
    {
        category = "Adult";
    }

    else
        category = "Old"; 
    
    Console.WriteLine($"Age: {age}, Category: {category}");
}
