//  Программа: Если введено положительное число, то возводи его в квадрат 

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()); // number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    number *= number; // number = number * number
    Console.WriteLine("Число возведённое в квадрат: " + number);
}
else
{
    Console.WriteLine("Число отрицательное");
}
Console.WriteLine("Мама дарагая! Как понять всё это!");