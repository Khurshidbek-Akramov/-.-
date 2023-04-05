Console.WriteLine("Введите кординаты Х У");
int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if ((X > 0) || (Y>0))
{
    Console.WriteLine("Первая четверть");
}

else if ((X < 0) || (Y>0))
{
    Console.WriteLine("Вторая четверть");
}

else if ((X < 0) || (Y<0))
{
    Console.WriteLine("Третья четверть");
}

else
{
    Console.WriteLine("Четвертая четверть");
}
