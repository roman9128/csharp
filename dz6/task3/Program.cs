// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Clear();
Console.Write("Введите текст на проверку: ");
string userstring = Console.ReadLine()!;
bool check = false;
for (int i = 0; i < userstring.Length / 2; i++)
{
    check = false;
    if (userstring[i] != userstring[userstring.Length - 1 - i])
    {
        break;
    }
    else
    {
        check = true;
    }
}
if (check == true)
{
    Console.WriteLine("Это палиндром");
}
if (check == false)
{
    Console.WriteLine("Это не палиндром");
}

// Код работает некорректно с кириллицей