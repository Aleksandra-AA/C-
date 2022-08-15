Console.WriteLine("Введите координаты точки А ");

double xA = double.Parse(Console.ReadLine());
Console.WriteLine("xA = " + xA);
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("yA = " + yA);

Console.WriteLine("Введите координаты точки B ");

double xB = double.Parse(Console.ReadLine());
Console.WriteLine("xB = " + xB);
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("yB = " + yB);

double distance(double xA, double yA, double xB, double yB)

{
    return Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
}

Console.WriteLine("Расстояние между точками А и В: " + distance(xA, xB, yA, yB));
