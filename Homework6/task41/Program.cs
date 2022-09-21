// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int count = 0; 
for (; ;)
{
    string? value = Console.ReadLine();
    if (value == "stop")
    {
        break;
    }
    else
    {
        if (Convert.ToInt32(value) > 0)
        {
          count++;
        }
    }
}
Console.WriteLine(count);
