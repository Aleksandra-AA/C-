Console.Clear();

Console.WriteLine("Введите число ");

string str = Console.ReadLine();

int l = str.Length;

if(l>=3)
{
    Console.WriteLine(str[2]);
}

if(l < 3)
{
    Console.WriteLine("третьей цифры нет");
}