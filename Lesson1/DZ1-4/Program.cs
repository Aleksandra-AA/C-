// Нахождение наибольшего числа из трех

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число В");
int B = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число C");
int C = int.Parse(Console.ReadLine());
    
if (A > B && A > C)
{ 
    Console.WriteLine("max:" + A);
} 

if (B > A && B > C)
{
    Console.WriteLine("max:" + B);
}

  if (C > A && C > B)
{
    Console.WriteLine("max:" + C);
}












