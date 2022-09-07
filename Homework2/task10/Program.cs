// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1




Random rand = new Random();  
int number = rand.Next(100, 1000);
Console.WriteLine($"Сгенирировать число {number}");
Console.WriteLine(number);
int digit = number;
digit = (number / 10) % 10; 
Console.WriteLine(digit);