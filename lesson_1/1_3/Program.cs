Console.WriteLine("Сейчас я найду сумму первой и последней цифры любого трёхзначного числа");
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(a/100 + a%10);