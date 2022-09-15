// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// // 9012 -> 12


int ReadNumber(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());  
}

int numberOfDigits(int num) 
{ 
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int namber = ReadNumber("Введите число:");
int num = numberOfDigits(namber);
Console.WriteLine($"Сумма цифр числа :  {num}");
