int Square (int value)
{
    int result = value * value;
    return result;
}

int Multiply (int value1, int value2)
{
    int result = value1 * value2;
    return result;
}

void ShowSquare (int value)
{
    int result = value * value;
    Console.Write(result);
}

// заполнить массив случайными числами
Random rnd = new Random();
int size = 1000;
int[] arr_int = new int [size];
int i = 0;
while(i < size)
{
    arr_int[i] = rnd.Next(1, 10); // второе число не включается, обрезается
    i++;
}

string input = Console.Readline(); //переменная для хранения введённой строки = модуль для работы с консолью
int value = Convert.ToInt32(input); // преобразование строки с числами в числа

// заполнить массив с консоли
int size = 10;
int[] arr_int = new int [size];
int i = 0;
while(i < size)
{
    Console.WriteLine("Введите элемент массива:");
    string input = Console.Readline();
    arr_int[i] = Convert.ToInt32(input); 
    i++;
}