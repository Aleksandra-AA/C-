Console.Clear();

string[] dayweek = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };

Console.WriteLine("Введите порядковый номер дня недели ");

int index = int.Parse(Console.ReadLine());

int l = dayweek.Length;
Console.WriteLine("День недели: " + dayweek[index - 1]);

if (index < 6)
{
    Console.WriteLine("Это выходной? Нет");
}
else
{
    Console.WriteLine("Это выходной? Да");
}

