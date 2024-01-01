Console.WriteLine("Введите число, а я выдам третью цифру с конца: ");
int a = int.Parse(Console.ReadLine()!);
if (a > 99)
    {
    Console.WriteLine(a / 100 % 10);
    }
else
    {
    Console.WriteLine("Третьей цифры нет");
    }