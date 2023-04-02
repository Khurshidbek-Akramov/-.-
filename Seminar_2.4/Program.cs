// Напишите программу, которая принимает на вход два числа
// и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.Write("Birinchi son ikkinchi sonning kvadrati");
}
else if (number2 == number1 * number1)
{
    Console.Write("Ikkinchi son birinchi sonning kvadrati");
}
else
{
    Console.Write("Bular bir-birining kvadrati emas");
}