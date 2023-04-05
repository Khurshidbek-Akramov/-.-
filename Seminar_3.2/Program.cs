Console.Write("Введите кординатор Х1 = ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кординатор Y1 = ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кординатор Х2 = ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кординатор Y2 = ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double number = Math.Sqrt((Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2)));
Console.WriteLine(number);