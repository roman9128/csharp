int[,] CreateMatrix(int row, int column) // функция по созданию матрицы
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}
void ShowMatrix(int[,] matrix) // функция по выводу матрицы
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
int CheckMatrix(int[,] matrix) // функция по решению задачи: нахождение суммы чисел на главной диагонали (индексы 0,0, 1,1 и т.д.)
{
    int sum = 0;
    // int i = 0;
    // int j = 0;
    // while (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    // {
    //     sum += matrix[i, j];
    //     i++;
    //     j++;
    // }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}

int[,] table = CreateMatrix(3, 4); // создание матрицы исходной с 3 строками и 4 столбцами
ShowMatrix(table); // вывод этой матрицы
int result = CheckMatrix(table); // создание переменной, в которую попадает результат работы функции
Console.WriteLine($"Сумма чисел главной диагонали равна {result}"); // вывод ответа