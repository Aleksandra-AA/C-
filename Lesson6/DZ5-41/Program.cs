int M = 8;
Console.WriteLine("Введите " + M + " чисел");

int count = 0;
for(int i = 0; i<M; i++) 
{
    Console.Write("Введите " + (i+1) + " число: ");
    if  (int.Parse(Console.ReadLine())>0) count++;
}
Console.WriteLine(count + " чисел больше нуля");