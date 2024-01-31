// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.Clear();
string MakeTextLower(string text)
{
    string lowtext = text.ToLower();
    return lowtext;
}
string randomtext = "Are you ready, kids? Aye, aye, Captain! I can't hear you! Aye, aye, Captain! Oh!";
string changedtext = MakeTextLower(randomtext);
Console.WriteLine(randomtext);
Console.WriteLine(changedtext);

/*
Эту задачу можно сделать иначе:

string randomtext = "Are you ready, kids? Aye, aye, Captain! I can't hear you! Aye, aye, Captain! Oh!";
Console.WriteLine(randomtext.ToLower());

*/
