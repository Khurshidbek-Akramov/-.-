// Напишите программу, которая выводит случайное число из отрезка
// [10, 99] и показывает наибольшую цифру числа.

int num =new Random().Next(10, 99);
Console.WriteLine(num);

int a = num / 10;
int b = num % 10;

if (a > b)
{  
    Console.WriteLine("Наибольщая цифра: " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + b);
}