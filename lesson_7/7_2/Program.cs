void PrintNumbers(int number)
{
    if (number != 0)
    {
        PrintNumbers(number - 1);
        Console.Write($"{number} ");
    }
}
Console.Write("Введите число, а я выдам все числа от 1 до него: ");
int num = int.Parse(Console.ReadLine()!);
PrintNumbers(num);