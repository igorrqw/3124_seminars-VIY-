// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int rowsCount = 3, int columnsCount = 4, int leftRange = 1, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("===================");

    int stringIndex = 0;
    int sumCount = 0;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;

        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix[i,j];
        }

        if (i == 0)
        {
           sumCount = sum;
        }

        if (sum < sumCount)
        {
            sumCount = sum; 
            stringIndex = i;
        }
    }

    Console.WriteLine($"строка: {stringIndex + 1}");
}

int[,] matr = GetMatrix();
PrintMatrix(matr);