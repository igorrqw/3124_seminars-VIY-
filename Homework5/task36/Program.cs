// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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

int[] arr = GetArray(4, 0, 150);
Console.WriteLine(string.Join(",", arr));

int sum = 0; 
for (int i = 0; i < arr.Length; i++)
{
    if (i%2 != 0)
        {
        sum +=arr[i];    
        }
}

Console.WriteLine("сумма="+sum);
