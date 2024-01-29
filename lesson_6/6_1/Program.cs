// Создать массив символов тип char, создайте строку из символов этого массива без склеивания

char[] letters = { 't', 'e', 's', 't' };
string MakeText(char[] bukovki)
{
    string text = "";
    foreach (char e in bukovki)
    {
        text += e;
    }
    return text;
}
string itog = MakeText(letters);
Console.WriteLine(itog);