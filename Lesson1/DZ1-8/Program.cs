Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

int count = 2;
Console.WriteLine("Четные числа ");

while (count < number)
{
    Console.WriteLine(count);
    count+=2;
}    