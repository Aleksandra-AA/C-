Console.WriteLine("Прямая задана уравнением y = k1 * x + b1");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая задана уравнением y = k2 * x + b2");
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

if (k1==k2 && b1==b2) 
{
    Console.WriteLine("Прямые совпадают");
} else if (k1==k2) 
{
    Console.WriteLine("Прямые параллельные");
} else 
{
    double x = -(b2-b1)/(k2-k1);
    double y = k1 * x + b1;
    Console.WriteLine("Точка пересечения прямых: (" + x + ", " + y + ")");
}