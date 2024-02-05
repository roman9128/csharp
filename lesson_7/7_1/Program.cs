int FindSum(int number)
{
    if (number == 0)
        return 0;
    return number % 10 + FindSum(number / 10);
}
Console.Write("Введите число, а я выдам сумму всех его цифр: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех цифр введённого числа: {FindSum(num)}");