Console.Write("Введите четверь ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number)
{
    case 1:
    {
        Console.WriteLine("X>0 и Y>0");
        break;
    }
    case 2:
    {
        Console.WriteLine("X>0 и Y<0");
        break;
    }
    case 3:
    {
        Console.WriteLine("X<0 и Y<0");
        break;
    }
    case 4:
    {
        Console.WriteLine("X<0 и Y>0");
        break;
    }
    default:
    {
        Console.WriteLine("Такой чертверть нет");
        break;
    }
}