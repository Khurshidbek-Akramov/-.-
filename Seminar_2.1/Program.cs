// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num =new Random().Next(100, 999);
Console.WriteLine(num);

int a = num / 100;
int b = num % 10;
Console.WriteLine(a * 10 + b);