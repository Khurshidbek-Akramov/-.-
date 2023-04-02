// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int a = number1 % 7;
int b = number1 % 23;

if ((a == 0) && (b == 0))
{
    Console.Write("Кратно");
}
else
{
    Console.Write("Не кратно");
}