void Square(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
Console.WriteLine("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Square(limit);
