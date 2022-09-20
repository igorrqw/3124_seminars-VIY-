// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

  

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

int[] arr = GetArray(5, 0, 150);
Console.WriteLine(string.Join(",", arr));
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
  if (arr[i]< min)
   {
      min = arr[i];      
   }
}
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
  if (arr[i]> max)
  {
    max = arr[i];
  }   
}
int result = max - min; 
Console.WriteLine($"разница {result}");
