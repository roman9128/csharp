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
int[,] CheckMatrix(int[,] matrix) // функция по решению задачи: возведение в квадрат чисел матрицы с чётными индексами
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] = matrix[i, j]*matrix[i, j];
        }
    }
    return matrix;
}

int[,] table = CreateMatrix(3, 4); // создание матрицы исходной с 3 строками и 4 столбцами
ShowMatrix(table); // вывод этой матрицы
int[,] table2 = CheckMatrix(table); // создание матрицы, в которую попадает результат работы функции
ShowMatrix(table2); // вывод матрицы с решением