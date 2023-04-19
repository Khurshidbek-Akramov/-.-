// Задача 45: Напишите программу, которая будет создавать копию заданного массива с
// помощью поэлементного копирования.
int [] array = new int[]{6, 7, 321, 15, 0, 7};
int [] result = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    result[i] = array [i];
}

for (int i = 0; i < result.Length; i++)
{
    System.Console.WriteLine(result[i]);
}