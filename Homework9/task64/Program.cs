// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintToB(int b)
{
    if (b <= 0)
    {
        return;
    }
    else 
    {
        Console.Write(b + " ");
        PrintToB(b - 1);
    }
}
 
int b =  ReadNumber("Введите число N: ");
PrintToB(b);