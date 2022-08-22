int summa (string str)
{
    int sum = 0;
    for(int l = 0; l < str.Length; l++)
    {
        sum = sum + int.Parse(str[l].ToString());
    }
    return sum;
}

Console.Clear();

Console.WriteLine("Введите число N:");

string str = Console.ReadLine();

Console.WriteLine("Сумма цифр числа от N: " + summa(str));