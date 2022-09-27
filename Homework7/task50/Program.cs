// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintMatrix(int[,] matrix,  int x,  int y)
{  
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    
    int height = matrix.GetLength(0);
    int width = matrix.GetLength(1);
    if (y < width && x < height)
    {
        Console.WriteLine(matrix[x, y]);
    }
    else
    {
       Console.WriteLine("такого числа в массиве нет");
    }
}   

int x = ReadNumber("Введите номер строки");
int y = ReadNumber("Введите номер элемента");
int[,] matr = GetMatrix();
PrintMatrix(matr,x,y);