Console.Clear();

Console.WriteLine("Введите число N:");
int number = int.Parse(Console.ReadLine());

int summa (int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum = i + sum;
    }
    return sum;
}


Console.WriteLine("Сумма чисел от 1 до N: " + summa(number));

// while (count <= number)
// {
//     int summa = Math.Sum(number);
//     Console.WriteLine(summa);
//     count += 1;
// }

//Console.WriteLine("Произведение чисел от 1 до N: ");

// while (count <= number)
// {
//     cube = Math.Pow(count, 3);
//     Console.WriteLine(cube);
//     count += 1;
// }
