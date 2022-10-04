// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;
void PrintToB(int a, int b )
{
    if (a > b)
    {
        return;
    }
    else 
    {
        PrintToB(a + 1, b);
        sum = sum + a;
    }
}

int a =  ReadNumber("Введите число M: ");
int b =  ReadNumber("Введите число N: ");
PrintToB(a,b);
Console.Write(sum);

// int sum = 0;
// void PrintToB(int a, int b )
// {
//     if (b < a)
//     {
//         return;
//     }
//     else 
//     {
//         PrintToB(a,b - 1);
//         sum = sum + b;
//     }
// }

// int a =  ReadNumber("Введите число M: ");
// int b =  ReadNumber("Введите число N: ");
// PrintToB(a,b);
// Console.Write(sum);




// ===========
// int ReadNumber(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int sum = 0;
// int m =  ReadNumber("Введите число M: ");
// int n =  ReadNumber("Введите число N: ");

// for (int i = m; i <= n; i++)
// {
//     sum = sum + i;
// }

// Console.Write($"-> {sum}");