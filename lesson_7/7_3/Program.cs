void RemoveVowels(string text, int i = 0)
{
    string vowels = "aeiouAEIOU";
    if (i == text.Length)
        return;
    if (vowels.Contains(text[i]) == false)
    {
        Console.Write(text[i] + " ");
        RemoveVowels(text, i + 1);
    }
    if (vowels.Contains(text[i]))
    {
        Console.Write("");
        RemoveVowels(text, i + 1);
    }
}
Console.Write("Enter your text: ");
string userstring = Console.ReadLine()!;
RemoveVowels(userstring);