Console.WriteLine("Write a sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(" ");

Array.Sort(words);

Console.WriteLine("Words in alphabetical order: ");

foreach(string word in words)
{
    Console.WriteLine(word);
}