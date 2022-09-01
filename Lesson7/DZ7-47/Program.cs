Console.WriteLine("Введите количество строк матрицы:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int M = int.Parse(Console.ReadLine());

double[,] matr = new double[N, M];
Random r = new Random();


for (int i=0; i<N; i++)
{
    for(int j=0;j<M; j++)
    {
        matr[i,j] = r.NextDouble();
        Console.Write(Math.Round(matr[i,j], 2) + " ");
    }
    Console.WriteLine();
}