Console.WriteLine("Введите координаты точки А ");

int x = int.Parse(Console.ReadLine());
Console.WriteLine("x = " + x);

int y = int.Parse(Console.ReadLine());
Console.WriteLine("y = " + y);

if ( x > 0 && y > 0) 
{
    Console.WriteLine("Точка А лежит в первой четверти");
}

if ( x > 0 && y < 0) 
{
    Console.WriteLine("Точка А лежит в четвертой четверти: ");
}

if ( x < 0 && y < 0) 
{
    Console.WriteLine("Точка А лежит в третьей четверти");
}

if ( x < 0 && y > 0) 
{
    Console.WriteLine("Точка А лежит во второй четверти");
}