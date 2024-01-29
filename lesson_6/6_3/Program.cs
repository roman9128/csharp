// Считать строку с консоли, состоящую из латинских букв в нижнем регистре, выяснить сколько среди них гласных

int CountVowels(string text)
{
    int count = 0;
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    foreach (char e in text)
    {
        if (vowels.Contains(e))
        {
            count++;
        }
    }
    return count;
}
Console.Write("Enter your text using low register: ");
string userstring = Console.ReadLine()!;
int countofvowels = CountVowels(userstring);
Console.WriteLine($"Amount of vowels in your text is {countofvowels}");