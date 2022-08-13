Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine());

int count = 1;
Console.WriteLine("Таблица кубов от 1 до N:");

while (count <= number)
{
    double cube = Math.Pow(count, 3);
    Console.WriteLine(cube);
    count += 1;
}