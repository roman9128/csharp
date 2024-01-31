// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] letters = {
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'},
    {'i', 'j', 'k', 'l'}
};
void Show(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
string MakeStringOf(char[,] matrix)
{
    string text = "";
    foreach (char e in matrix)
    {
        text += e;
    }
    return text;
}
Console.WriteLine("The matrix contains the following letters:");
Show(letters);
string randomtext = MakeStringOf(letters);
Console.WriteLine($"Text of letters: {randomtext}");