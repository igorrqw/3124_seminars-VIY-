// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); 
    }  
    return arr;
}
int[] arr = GetArray(4, 100, 1000);
Console.WriteLine(string.Join(",", arr));
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if ((arr[i] % 2) == 0)
count++;
}
Console.Write(count);