List<string> words = new List<string>();
string input;

Console.WriteLine("Kelime giriniz (Çıkış için 'exit' yazın):");

while (true)
{
    Console.Write("Kelime: ");
    input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    words.Add(input);
}

Console.WriteLine("\nGirilen kelimelerin tersten yazılmış hali:");
foreach (string word in words)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    Console.WriteLine(new string(charArray));
}