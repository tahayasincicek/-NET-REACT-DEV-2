string[] words = { "apple", "banana", "strawberry", "kiwi", "melon" };
string longest = words[0];
string shortest = words[0];
foreach(string word in words)
{
    if (word.Length > longest.Length)
    {
        longest = word;
    }

    
}
foreach(string word2 in words)
{
    if (word2.Length < shortest.Length)
    {
        shortest = word2;
    }

}
Console.WriteLine("Longest word is : " + longest);
Console.WriteLine("Shortest word is : " + shortest);
