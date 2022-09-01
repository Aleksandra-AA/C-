
Console.WriteLine("Введите количество строк матрицы:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int M = int.Parse(Console.ReadLine());

int[,] matr = new int[N, M];
Random r = new Random();

for (int i=0; i<N; i++)
{
    for(int j=0;j<M; j++)
    {
        matr[i,j] = r.Next(0,10);
        Console.Write(matr[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число:");
int K = int.Parse(Console.ReadLine());
bool isElementInMassiv = false;
for (int i=0; i<N; i++)
{
    for(int j=0;j<M; j++)
    {
        if (matr[i,j] == K) {
            Console.WriteLine($"Координаты:({i}, {j})");
            isElementInMassiv = true;
        }
    }
}

if (!isElementInMassiv) Console.WriteLine("Такого числа в массиве нет");
