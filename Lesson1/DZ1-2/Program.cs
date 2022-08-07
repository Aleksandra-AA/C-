// Программа, которая определяет большее  из двух чисел

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("max:" + A);
}

if (A < B)
{
    Console.WriteLine("max:" + B);
}
if (A == B)
{
    Console.WriteLine("Числа равны");
}