// Задача 24: Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Write("Введите число А = ");
int A = Convert.ToInt32(Console.ReadLine());

int GetSumNum()
{
    int sum = 0;
    int count = 0;

    while(count < A)
    {
        count++;
        sum+=count;
    }
    return sum;
}

int number = GetSumNum();
Console.WriteLine(number);