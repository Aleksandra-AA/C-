Console.Clear();
int number = new Random().Next(100, 1000);

Console.WriteLine("Случайное трёхзначное число " + number);
string str = number.ToString();

Console.WriteLine(str[0].ToString() + str[2].ToString());
