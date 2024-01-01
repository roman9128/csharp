Console.WriteLine("Введите два числа, а я проверю, кратно ли второе первому, если нет, то выдам остаток от деления: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a % b == 0)
    {
    Console.WriteLine("Да");
    }
else
    {
    Console.WriteLine("Нет, " + a % b);
    }