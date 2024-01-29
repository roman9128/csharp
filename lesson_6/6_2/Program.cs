// На основе символов строки сформировать массив символов

char[] MakeArrayOfText(string bukovki)
{
    char[] letters = new char[bukovki.Length];
    for (int i = 0; i < letters.Length; i++)
    {
        letters[i] = bukovki[i];
    }
    return letters;
}
void PrintArray(char[] arr)
{
    Console.Write("Массив содержит следующее: ");
    foreach (char e in arr)
    {
        Console.Write($"'{e}' ");
    }
}
string userstring = Console.ReadLine();
char[] itog = MakeArrayOfText(userstring);
PrintArray(itog);