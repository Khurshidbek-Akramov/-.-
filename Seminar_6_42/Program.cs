// Вадим: Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string counter = "";

while (n >= 1)
{
    counter = (n % 2) + counter;
    n = n / 2;
}
Console.WriteLine(counter);