﻿// Задача 28: Напишите программу, которая принимает на
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
int fact = 1;

while (count <= number)
{
    fact *=count;
    count++;
}
Console.WriteLine("Фактарял: " + fact);