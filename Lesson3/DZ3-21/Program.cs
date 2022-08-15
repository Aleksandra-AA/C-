Console.WriteLine("Введите координаты точки А ");

double xA = double.Parse(Console.ReadLine());
Console.WriteLine("xA = " + xA);
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("yA = " + yA);
double zA = double.Parse(Console.ReadLine());
Console.WriteLine("zA = " + zA);

Console.WriteLine("Введите координаты точки B ");

double xB = double.Parse(Console.ReadLine());
Console.WriteLine("xB = " + xB);
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("yB = " + yB);
double zB = double.Parse(Console.ReadLine());
Console.WriteLine("zB = " + zB);


double distance(double xA, double yA, double zA, double xB, double yB, double zB)

{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}

Console.WriteLine("Расстояние между точками А и В: " + distance(xA, yA, zA, xB, yB, zB));
