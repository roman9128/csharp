// Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

Console.Clear();
string ReverseText(string text)
{
    string[] words = text.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
    string reversedsentence = "";
    string temp = "";
    int i = 0;
    while (i < words.Length / 2)
    {
        temp = words[i];
        words[i] = words[words.Length - 1 - i];
        words[words.Length - 1 - i] = temp;
        i++;
    }
    foreach (string e in words)
    {
        reversedsentence = reversedsentence + e + " ";
    }
    return reversedsentence;
}
Console.Write("Enter your text: ");
string userstring = Console.ReadLine()!;
string reversed = ReverseText(userstring);
Console.WriteLine($"Here is reversed text: {reversed}");