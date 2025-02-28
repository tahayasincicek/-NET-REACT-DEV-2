string[] words = new string[0]; // Initially an empty array

while (true)
{
    Console.Write("Enter a word (Press 'q' to quit): ");
    string word = Console.ReadLine();

    if (word.ToLower() == "q") // Exit condition
        break;

    // Create a new array with an increased size
    string[] newArray = new string[words.Length + 1];

    // Copy the existing elements to the new array
    for (int i = 0; i < words.Length; i++)
    {
        newArray[i] = words[i];
    }

    // Add the new word to the last position
    newArray[newArray.Length - 1] = word;

    // Update the original array reference
    words = newArray;

    Console.WriteLine($"Updated Array: {string.Join(", ", words)}");
}