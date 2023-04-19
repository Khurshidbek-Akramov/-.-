// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int max = int.MaxValue;
int count = 0;
for (int i = 0; i < max; i++)
{
    Console.WriteLine("Введите число, если закончили ввод введите 00 ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num==00)
    {
        break;
    }
    if (num>0)
    {
        count++;
    }
}
Console.WriteLine("Ползователь ввел "+count+" шт. чисел больше 0");