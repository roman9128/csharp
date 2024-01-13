// Программа для проверки наличия числа в массиве

int[] arr = { 1, 3, 4, 19, 3, -4, -8, 5 };
Console.Write("Введите число, а я проверю, есть ли оно в массиве: ");
int n = int.Parse(Console.ReadLine()!);
bool check = false;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == n)
    {
        check = true;
        break; // оператор остановки операции
    }
}
if (check)
    {
        Console.WriteLine("Да");
    }
else
    {
        Console.WriteLine("Нет");
    }