Console.Clear();

Console.WriteLine("Введите число ");

string str = Console.ReadLine();

string reverse = "";

for (int l = str.Length - 1; l >= 0; l--)
    reverse += str[l];

if (str == reverse)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}


//int l = str.Length;

// int index = 0;

// while (index < l)
// {
//     string newstr = l - 1 - index;
//     index++;
// }

// Console.WriteLine(newstr);
