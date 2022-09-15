// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги! 

Console.WriteLine("Введите числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < b; i++) 
{
   result = result * a;
}

Console.WriteLine($"Число в степени {result}");