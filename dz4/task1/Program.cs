// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.Clear();
while (true)
{
    Console.WriteLine("Чтобы выйти, введите число, сумма цифр которого чётная, или нажмите 'q'");
    string input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    int number;
    if (int.TryParse(input, out number))
    {
        int numsum = 0;
        while (number > 0)
        {
            numsum = numsum + number % 10;
            number = number / 10;
        }
        if (numsum % 2 == 0)
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Попробуйте ещё раз");
    }
}